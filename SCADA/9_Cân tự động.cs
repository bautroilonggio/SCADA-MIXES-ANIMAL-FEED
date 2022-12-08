using SCADA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SymbolFactoryDotNet;
using S7.Net;
using S7.Net.Types;

namespace BTL
{
    public partial class frm_CanTuDong : Form
    {
        public frm_CanTuDong()
        {
            InitializeComponent();
        }

        public class ThongTin
        {
            static public decimal[] KLTSilo = new decimal[16];  //Nơi lưu tạm thời khối lượng thực
        }

        #region PhuongThucNhap
        //Chỉ nhập được các số thực không âm
        private void txt_KhoiLuongA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;       //Bỏ qua những cú pháp không hợp lệ
        }

        private void txt_KhoiLuongB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KhoiLuongC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }
        #endregion PhuongThucNhap

        string chuoiketnoi = @"Data Source=LINK\KHACLINH;Initial Catalog=SCADA;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;

        //Khai báo mảng chứa số,nguyên liệu,khối lượng đặt, khối lượng thực, TT Cân các Silo
        TextBox[] txt_Silo, txt_NLSilo, txt_KLDSilo, txt_KLTSilo, txt_SaiSoSilo, txt_TTCan;
        TextBox[] txt_NLSL;     //Nguyên liệu hiển thị trên các Silo
        StandardControl[] DenSilo;       //Đèn trên mỗi Silo
        StandardControl[] Silo;       //Silo
        int SoSilo = 15;
        int checkClickSilo = 0;     //STT Silo được chọn
        decimal t;

        PLC_Command PLC_Com = new PLC_Command();

        // Chương trình con hiển thị trạng thái các đèn
        private void Den(StandardControl ob, bool value)
        {
            if (value == true)
                ob.DiscreteValue1 = true;
            else
                ob.DiscreteValue1 = false;
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            txt_ThoiGian.Text = DateTime.Now.ToString();
        }

        private void ChuKyQuet_Tick(object sender, EventArgs e)
        {
            //Kết nối PLC
            if (SCADA.ThongTin.checkKetNoi == true)
            {
                lbl_TrangThaiKetNoi.Text = "Đã kết nối cân";
                lbl_TrangThaiKetNoi.ForeColor = Color.White;
                btn_Can.Enabled = true;
                btn_Reset.Enabled = true;
                btn_ThemMe.Enabled = true;
                btn_DoiSiloCanA.Enabled = true;
                btn_DoiSiloCanB.Enabled = true;
                btn_CaiDatFine.Enabled = true;
                btn_ChoPhepCan.Enabled = true;
                btn_ChoXaCan.Enabled = true;
                btn_ChoXaTron.Enabled = true;
                btn_NgungXaTron.Enabled = true;

                for(int i = 0;i <= SoSilo;i++)
                {
                    if (txt_TTCan[i].Text.Length != 0)
                    {
                        Silo[i].Enabled = true;
                        DenSilo[i].Enabled = true;
                    }
                }

                // Đọc dữ liệu DB1
                SCADA.ThongTin.plc.ReadClass(PLC_Com, 1);
                Den(Den1, PLC_Com.tag_Den1);
                Den(Den2, PLC_Com.tag_Den2);
                Den(Den3, PLC_Com.tag_Den3);
                Den(Den4, PLC_Com.tag_Den4);
                Den(Den5, PLC_Com.tag_Den5);
                Den(Den6, PLC_Com.tag_Den6);
                Den(Den7, PLC_Com.tag_Den7);
                Den(Den8, PLC_Com.tag_Den8);
                Den(Den9, PLC_Com.tag_Den9);
                Den(Den10, PLC_Com.tag_Den10);
                Den(Den11, PLC_Com.tag_Den11);
                Den(Den12, PLC_Com.tag_Den12);
                Den(Den13, PLC_Com.tag_Den13);
                Den(Den14, PLC_Com.tag_Den14);
                Den(Den15, PLC_Com.tag_Den15);
                Den(DenThemTay, PLC_Com.tag_Den16);
                Den(DenCanA, PLC_Com.tag_DenCPC1);
                Den(DenCanB, PLC_Com.tag_DenCPC2);
                Den(DenCanC, PLC_Com.tag_DenCPC3);
            }
            else
            {
                btn_Can.Enabled = false;
                btn_Reset.Enabled = false;
                btn_ThemMe.Enabled = false;
                btn_DoiSiloCanA.Enabled = false;
                btn_DoiSiloCanB.Enabled = false;
                btn_CaiDatFine.Enabled = false;
                btn_ChoPhepCan.Enabled = false;
                btn_ChoXaCan.Enabled = false;
                btn_ChoXaTron.Enabled = false;
                btn_NgungXaTron.Enabled = false;
                for (int i = 0; i <= SoSilo; i++)
                {
                    Silo[i].Enabled = false;
                    DenSilo[i].Enabled = false;
                }
            }    
            
            //Tổng số mẻ
            txt_TongSoMe.Text = SCADA.ThongTin.TongSoMe.ToString();

            //Tổng khối lượng nguyên liệu
            txt_KhoiLuongNL.Text = (SCADA.ThongTin.TongSoMe * SCADA.ThongTin.KL_Me).ToString();

            //Tính sai lệch khối lượng
            for (int i = 0; i <= SoSilo; i++)
            {
                if (txt_KLTSilo[i].Text == "")
                    txt_SaiSoSilo[i].Text = "";
                else
                    txt_SaiSoSilo[i].Text = (decimal.Parse(txt_KLTSilo[i].Text) - decimal.Parse(txt_KLDSilo[i].Text)).ToString();
            }

        }

        private void ganMang()      //Tạo các mảng chứa số,nguyên liệu, khối lượng đặt, khối lượng thực, thứ tự cân Silo
        {
            txt_Silo = new TextBox[] {txt_Silo1,txt_Silo2,txt_Silo3,txt_Silo4,txt_Silo5,txt_Silo6,txt_Silo7,
            txt_Silo8,txt_Silo9,txt_Silo10,txt_Silo11,txt_Silo12,txt_Silo13,txt_Silo14,txt_Silo15,txt_SiloThem};

            txt_NLSilo = new TextBox[] {txt_NLSilo1,txt_NLSilo2,txt_NLSilo3,txt_NLSilo4,txt_NLSilo5,txt_NLSilo6,txt_NLSilo7,
            txt_NLSilo8,txt_NLSilo9,txt_NLSilo10,txt_NLSilo11,txt_NLSilo12,txt_NLSilo13,txt_NLSilo14,txt_NLSilo15,txt_NLThemTay};

            txt_KLDSilo = new TextBox[] {txt_KLDSilo1,txt_KLDSilo2,txt_KLDSilo3,txt_KLDSilo4,txt_KLDSilo5,txt_KLDSilo6,txt_KLDSilo7,
            txt_KLDSilo8,txt_KLDSilo9,txt_KLDSilo10,txt_KLDSilo11,txt_KLDSilo12,txt_KLDSilo13,txt_KLDSilo14,txt_KLDSilo15,txt_KLDThem};

            txt_KLTSilo = new TextBox[] {txt_KLTSilo1,txt_KLTSilo2,txt_KLTSilo3,txt_KLTSilo4,txt_KLTSilo5,txt_KLTSilo6,txt_KLTSilo7,
            txt_KLTSilo8,txt_KLTSilo9,txt_KLTSilo10,txt_KLTSilo11,txt_KLTSilo12,txt_KLTSilo13,txt_KLTSilo14,txt_KLTSilo15,txt_KLTThem};

            txt_SaiSoSilo = new TextBox[] {txt_SaiSoSilo1,txt_SaiSoSilo2,txt_SaiSoSilo3,txt_SaiSoSilo4,txt_SaiSoSilo5,txt_SaiSoSilo6,txt_SaiSoSilo7,
            txt_SaiSoSilo8,txt_SaiSoSilo9,txt_SaiSoSilo10,txt_SaiSoSilo11,txt_SaiSoSilo12,txt_SaiSoSilo13,txt_SaiSoSilo14,txt_SaiSoSilo15,txt_SaiSoThem};

            txt_TTCan = new TextBox[] {txt_TTCan1,txt_TTCan2,txt_TTCan3,txt_TTCan4,txt_TTCan5,txt_TTCan6,txt_TTCan7,
            txt_TTCan8,txt_TTCan9,txt_TTCan10,txt_TTCan11,txt_TTCan12,txt_TTCan13,txt_TTCan14,txt_TTCan15,txt_TTCanThem};

            txt_NLSL = new TextBox[] {txt_NLSL1,txt_NLSL2,txt_NLSL3,txt_NLSL4,txt_NLSL5,txt_NLSL6,txt_NLSL7,
            txt_NLSL8,txt_NLSL9,txt_NLSL10,txt_NLSL11,txt_NLSL12,txt_NLSL13,txt_NLSL14,txt_NLSL15,txt_NLSLThem};

            DenSilo = new StandardControl[] { Den1, Den2, Den3, Den4, Den5, Den6, Den7, Den8, Den9, Den10,
            Den11, Den12, Den13, Den14, Den15, DenThemTay };

            Silo = new StandardControl[] { Silo1, Silo2, Silo3, Silo4, Silo5, Silo6, Silo7, Silo8, Silo9, Silo10,
            Silo11, Silo12, Silo13, Silo14, Silo15, SiloThemTay};

        }

        void LoadData()         //Load dữ liệu xuống bảng và các silo
        {
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            if (txt_SoHieuCt.Text != "")
            {
                sql = "Select Nguyen_Lieu,Khoi_Luong,TT_Can FROM " + txt_SoHieuCt.Text + "";
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();   //Đọc dữ liệu Tên nguyên liệu
                int i = 0;
                while (docdulieu.Read())
                {
                    if (i <= SoSilo)
                    {
                        txt_NLSilo[i].Text = docdulieu[0].ToString();
                        txt_NLSL[i].Text = docdulieu[0].ToString();
                        txt_KLDSilo[i].Text = docdulieu[1].ToString();
                        txt_TTCan[i].Text = docdulieu[2].ToString();
                    }
                    i++;
                }
            }
            ketnoi.Close();
        }

        void LoadSilo()      //Silo nào không có nguyên liệu thì không chọn đươc, không có đèn báo và không ghi được khối lượng
        {
            for(int i = 0;i<=SoSilo;i++)
            {
                if (txt_TTCan[i].Text.Length == 0)
                {
                    DenSilo[i].Visible = false;
                    Silo[i].Enabled = false;
                    txt_KLTSilo[i].ReadOnly = true;
                }
            }    
        }

        public long QuyDoiThoiGian(DateTime date)        //Quy đổi thời gian về 1 số nguyên
        {
            int nam, thang, ngay, gio, phut, giay;
            nam = date.Year;
            thang = date.Month;
            ngay = date.Day;
            gio = date.Hour;
            phut = date.Minute;
            giay = date.Second;
            long ThoiGian = 0;
            ThoiGian = giay + 100 * phut + 10000 * gio + ngay * 1000000 + thang * 100000000 + nam * 10000000000;
            return ThoiGian;
        }

        private void frm_CanTuDong_Load(object sender, EventArgs e)
        {
            ThoiGian.Start();
            ChuKyQuet.Start();

            txt_SoHieuCt.Text = SCADA.ThongTin.soHieuCt;
            
            txt_KhoiLuongMe.Text = SCADA.ThongTin.KL_Me.ToString();
            txt_ThoiGianTron.Text = SCADA.ThongTin.TgTron.ToString();
            txt_ThoiGianXaTron.Text = SCADA.ThongTin.TgXaTron.ToString();

            txt_TgTreCanF.Text = SCADA.ThongTin.TgTreCanF;
            txt_TgTreFNghien.Text = SCADA.ThongTin.TgTreFNghien;
            txt_TgTreNghienH.Text = SCADA.ThongTin.TgTreNghienH;
            txt_TgTreHTron.Text = SCADA.ThongTin.TgTreHTron;

               

            ketnoi = new SqlConnection(chuoiketnoi);
            ganMang();
            LoadData();
            LoadSilo();

            txt_KhoiLuongA.ReadOnly = true;
            txt_KhoiLuongB.ReadOnly = true;
            txt_KhoiLuongC.ReadOnly = true;

            for(int i = 0;i<=SoSilo;i++)
            {
                if (frm_CanTuDong.ThongTin.KLTSilo[i] != 0)
                    txt_KLTSilo[i].Text = frm_CanTuDong.ThongTin.KLTSilo[i].ToString();
            }
        }

        private void doimau(int index)      //Đổi màu hàng tương ứng khi click vào Silo, hàng nào đổi màu mới chỉnh sửa được
        {
            for (int i = 0; i <= SoSilo; i++)
            {
                if (i == index)
                {
                    txt_Silo[i].BackColor = Color.GreenYellow;
                    txt_NLSilo[i].BackColor = Color.GreenYellow;
                    txt_KLDSilo[i].BackColor = Color.GreenYellow;
                    txt_KLTSilo[i].BackColor = Color.GreenYellow;
                    txt_SaiSoSilo[i].BackColor = Color.GreenYellow;
                    txt_TTCan[i].BackColor = Color.GreenYellow;
                }
                else
                {
                    txt_Silo[i].BackColor = Color.White;
                    txt_NLSilo[i].BackColor = Color.White;
                    txt_KLDSilo[i].BackColor = Color.White;
                    txt_KLTSilo[i].BackColor = Color.White;
                    txt_SaiSoSilo[i].BackColor = Color.White;
                    txt_TTCan[i].BackColor = Color.White;
                }
            }
        }

        #region ChonSilo
        private void Silo1_Click(object sender, EventArgs e)
        {
            checkClickSilo = 1;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M0.1", 1);
            SCADA.ThongTin.plc.Write("M0.1", 0);
        }

        private void Silo2_Click(object sender, EventArgs e)
        {
            checkClickSilo = 2;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M0.2", 1);
            SCADA.ThongTin.plc.Write("M0.2", 0);
        }

        private void Silo3_Click(object sender, EventArgs e)
        {
            checkClickSilo = 3;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M0.3", 1);
            SCADA.ThongTin.plc.Write("M0.3", 0);
        }

        private void Silo4_Click(object sender, EventArgs e)
        {
            checkClickSilo = 4;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M0.4", 1);
            SCADA.ThongTin.plc.Write("M0.4", 0);
        }

        private void Silo5_Click(object sender, EventArgs e)
        {
            checkClickSilo = 5;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M0.5", 1);
            SCADA.ThongTin.plc.Write("M0.5", 0);
        }

        private void Silo6_Click(object sender, EventArgs e)
        {
            checkClickSilo = 6;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M0.6", 1);
            SCADA.ThongTin.plc.Write("M0.6", 0);
        }

        private void Silo7_Click(object sender, EventArgs e)
        {
            checkClickSilo = 7;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M0.7", 1);
            SCADA.ThongTin.plc.Write("M0.7", 0);
        }

        private void Silo8_Click(object sender, EventArgs e)
        {
            checkClickSilo = 8;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M1.0", 1);
            SCADA.ThongTin.plc.Write("M1.0", 0);
        }

        private void Silo9_Click(object sender, EventArgs e)
        {
            checkClickSilo = 9;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M1.1", 1);
            SCADA.ThongTin.plc.Write("M1.1", 0);
        }

        private void Silo10_Click(object sender, EventArgs e)
        {
            checkClickSilo = 10;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M1.2", 1);
            SCADA.ThongTin.plc.Write("M1.2", 0);
        }

        private void Silo11_Click(object sender, EventArgs e)
        {
            checkClickSilo = 11;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M1.3", 1);
            SCADA.ThongTin.plc.Write("M1.3", 0);
        }

        private void Silo12_Click(object sender, EventArgs e)
        {
            checkClickSilo = 12;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M1.4", 1);
            SCADA.ThongTin.plc.Write("M1.4", 0);
        }

        private void Silo13_Click(object sender, EventArgs e)
        {
            checkClickSilo = 13;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M1.5", 1);
            SCADA.ThongTin.plc.Write("M1.5", 0);
        }

        private void Silo14_Click(object sender, EventArgs e)
        {
            checkClickSilo = 14;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M1.6", 1);
            SCADA.ThongTin.plc.Write("M1.6", 0);
        }

        private void Silo15_Click(object sender, EventArgs e)
        {
            checkClickSilo = 15;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M1.7", 1);
            SCADA.ThongTin.plc.Write("M1.7 ", 0);
        }

        private void SiloThemTay_Click(object sender, EventArgs e)
        {
            checkClickSilo = 16;
            doimau(checkClickSilo - 1);
            SCADA.ThongTin.plc.Write("M2.3", 1);
            SCADA.ThongTin.plc.Write("M2.3", 0);
        }
        #endregion ChonSilo

        private void btn_Can_Click(object sender, EventArgs e)
        {
            if (txt_SoHieuCt.Text == "")
            {
                MessageBox.Show("Thiếu thông tin cài đặt tổng quát", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                DialogResult check = MessageBox.Show("Bạn có muốn cài đặt tổng quát không ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    frm_Home.ThongTin.checkCaiDatTongQuat = false;
                    frm_CaiDatTong frm = new frm_CaiDatTong();
                    frm.Show();
                    this.Close();
                }
                return;
            }
            if(txt_TgTreCanF.Text==""|txt_TgTreFNghien.Text==""|txt_TgTreNghienH.Text==""|txt_TgTreHTron.Text=="")
            {
                MessageBox.Show("Thiếu thông tin cài đặt thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult check = MessageBox.Show("Bạn có muốn cài đặt thời gian không ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    frm_Home.ThongTin.checkCaiDatThoiGian = false;
                    frm_CatDatTg frm = new frm_CatDatTg();
                    frm.Show();
                    this.Close();
                }
                return;
            }    
        }

        private void btn_ChoPhepCan_Click(object sender, EventArgs e)
        {
            if (txt_SoHieuCt.Text == "")
            {
                MessageBox.Show("Thiếu thông tin cài đặt tổng quát", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Tắt hết đèn ở các Silo và bật đèn, cho phép ghi khối lượng trên các cân tương ứng
            if (checkClickSilo == 16)       //Silo thêm tay
            {
                SCADA.ThongTin.plc.Write("M2.5", 1);
                SCADA.ThongTin.plc.Write("M2.5", 0);
                txt_KhoiLuongC.ReadOnly = false;
            }
            else if (checkClickSilo <= 9)   //Silo cân A
            {
                SCADA.ThongTin.plc.Write("M2.1", 1);
                SCADA.ThongTin.plc.Write("M2.1", 0);
                txt_KhoiLuongA.ReadOnly = false;
            }
            else                            //Silo cân B
            {
                SCADA.ThongTin.plc.Write("M2.4", 1);
                SCADA.ThongTin.plc.Write("M2.4", 0);
                txt_KhoiLuongB.ReadOnly = false;
            }
        }

        private void btn_ChoXaCan_Click(object sender, EventArgs e)
        {
            if(txt_SoHieuCt.Text == "")
            {
                MessageBox.Show("Thiếu thông tin cài đặt tổng quát", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Tắt hết đèn trên các cân
            SCADA.ThongTin.plc.Write("M2.2", 1);
            SCADA.ThongTin.plc.Write("M2.2", 0);

            //Không cho ghi khối lượnjg trên các cân
            txt_KhoiLuongA.ReadOnly = true;
            txt_KhoiLuongB.ReadOnly = true;
            txt_KhoiLuongC.ReadOnly = true;

            //Bật các đèn báo xả cân và hiển thị khối lượng cân được lên bảng
            if (checkClickSilo == 16)
            {
                if(txt_KhoiLuongC.Text == "")
                {
                    MessageBox.Show("Thiếu dữ liệu khối lượng thực cân thêm tay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }    
                txt_KLTThem.Text = txt_KhoiLuongC.Text;
                frm_CanTuDong.ThongTin.KLTSilo[15] = decimal.Parse(txt_KhoiLuongC.Text);
                DenXaCanC.DiscreteValue1 = true;
            }
            else if (checkClickSilo <= 9)
            {
                if (txt_KhoiLuongA.Text == "")
                {
                    MessageBox.Show("Thiếu dữ liệu khối lượng thực cân A", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txt_KLTSilo[checkClickSilo - 1].Text = txt_KhoiLuongA.Text;
                frm_CanTuDong.ThongTin.KLTSilo[checkClickSilo - 1] = decimal.Parse(txt_KhoiLuongA.Text);
                DenXaCanA1.DiscreteValue1 = true;
                DenXaCanA2.DiscreteValue1 = true;
            }
            else
            {
                if (txt_KhoiLuongB.Text == "")
                {
                    MessageBox.Show("Thiếu dữ liệu khối lượng thực cân B", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txt_KLTSilo[checkClickSilo - 1].Text = txt_KhoiLuongB.Text;
                frm_CanTuDong.ThongTin.KLTSilo[checkClickSilo - 1] = decimal.Parse(txt_KhoiLuongB.Text);
                DenXaCanB.DiscreteValue1 = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Tắt hết đèn trên Silo và các cân
            SCADA.ThongTin.plc.Write("M2.6", 1);
            SCADA.ThongTin.plc.Write("M2.6", 0);

            //Tắt hết đèn xả cân
            DenXaCanA1.DiscreteValue1 = false;
            DenXaCanA2.DiscreteValue1 = false;
            DenXaCanB.DiscreteValue1 = false;
            DenXaCanC.DiscreteValue1 = false;
        }

        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            frm_DiaChiIP frm = new frm_DiaChiIP();
            frm.Show();

            t = decimal.Parse(txt_TgTreCanF.Text) + decimal.Parse(txt_TgTreFNghien.Text)
                + decimal.Parse(txt_TgTreHTron.Text) + decimal.Parse(txt_TgTreNghienH.Text);
            t = Math.Round(1000*t, 0);
            int ThoiGianTre = (int)t;
            int ThoiGianTron = (int)(1000 * int.Parse(txt_ThoiGianTron.Text));
            int ThoiGianXaTron = (int)(1000 * int.Parse(txt_ThoiGianXaTron.Text));

            led_Tron.DiscreteValue1 = false;
            led_Tron.DiscreteValue2 = false;

            Task.Delay(ThoiGianTre);
            led_Tron.DiscreteValue1 = true;
            Task.Delay(ThoiGianTron);
            led_Tron.DiscreteValue1 = false;
            led_Tron.DiscreteValue2 = true;
            Task.Delay(ThoiGianXaTron);
            led_Tron.DiscreteValue2 = false;
        }

        private void btn_GhiDuLieu_Click(object sender, EventArgs e)
        {
            if (txt_SoHieuCt.Text == "" | txt_SoMeDaCan.Text == "")
            {
                MessageBox.Show("Thiếu thông tin cân");
                return;
            }
            for (int i = 0; i <= SoSilo; i++)
            {
                if (txt_KLDSilo[i].Text != "0" && txt_KLTSilo[i].Text == "")
                {
                    DialogResult check = MessageBox.Show("Thiếu thông tin khối lượng! Bạn có chắc muốn ghi thông tin không ?",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (check == DialogResult.No)
                        return;
                }
            }
            int MeSo;
            if (int.Parse(txt_SoMeDaCan.Text) < int.Parse(txt_TongSoMe.Text))
                MeSo = int.Parse(txt_SoMeDaCan.Text) + 1;
            else
                MeSo = int.Parse(txt_SoMeDaCan.Text);

            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            for (int i = 0; i <= SoSilo; i++)
            {
                sql = @"INSERT INTO Du_Lieu_Can (NgayGhi,ThoiGianGhi,MeSo,SoHieuCongThuc,Silo,NguyenLieu,KhoiLuongDat,KhoiLuongThuc,SaiLech,ThuTuCan,NgayGhiInt)
                values (N'" + DateTime.Now.ToShortDateString() + "',N'" + DateTime.Now.ToLongTimeString() + "',N'" + MeSo.ToString() + "'," +
                "N'" + txt_SoHieuCt.Text + "',N'" + txt_Silo[i].Text + "',N'" + txt_NLSilo[i].Text + "',N'" + txt_KLDSilo[i].Text + "'," +
                "N'" + txt_KLTSilo[i].Text + "',N'" + txt_SaiSoSilo[i].Text + "',N'" + txt_TTCan[i].Text + "'," +
                "'" + QuyDoiThoiGian(DateTime.Now).ToString() + "')";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            ketnoi.Close();
            MessageBox.Show("Đã lưu dữ liệu cân");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            frm_Home frm = new frm_Home();
            frm.Show(); //Mở form Home
            this.Close();    //Tắt form này đi
        }
        private void btn_CaiDatFine_Click(object sender, EventArgs e)
        {
            frm_CaiDatFine frm = new frm_CaiDatFine();
            frm.Show();
        }

        private void btn_ThemMe_Click(object sender, EventArgs e)
        {
            frm_ThemMe frm = new frm_ThemMe();
            frm.Show();
        }

        private void btn_CaiDatTg_Click(object sender, EventArgs e)
        {
            frm_Home.ThongTin.checkCaiDatThoiGian = false;
            frm_CatDatTg frm = new frm_CatDatTg();
            frm.Show();
            this.Hide();
        }

        

    }
}
