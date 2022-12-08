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

namespace SCADA
{
    public partial class frm_CaiDatCt : Form
    {
        public frm_CaiDatCt()
        {
            InitializeComponent();
        }

        #region PhuongThucNhap
        //Chỉ cho phép nhập khối lượng là số thực không âm
        private void txt_KLSilo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;       //Bỏ qua những cú pháp không hợp lệ
        }

        private void txt_KLSilo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLSilo15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_KLThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        //Chỉ cho phép nhập thứ tự cân là số tự nhiên
        private void txt_TTCan1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCan15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txt_TTCanThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        #endregion PhuongThucNhap

        TextBox[] txt_Silo,txt_NLSilo, txt_KLSilo, txt_TTCan;    //Khai báo mảng chứa số,nguyên liệu,khối lượng, TT Cân các Silo
        int SiloIndex = -1, SoSilo = 15;
        float TongKL = 0;
        bool checkTinhTong;     //khi bấm nút Lưu thì check xem đã tính tổng hay chưa

        string chuoiketnoi = @"Data Source=LINK\KHACLINH;Initial Catalog=SCADA;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;

        private void frm_Ct_Load(object sender, EventArgs e)
        {
            txt_CongThuc.Text = frm_KhaiBaoCt.ThongTin.tenCt;
            txt_SoHieuCt.Text = frm_KhaiBaoCt.ThongTin.soHieuCt;

            ketnoi = new SqlConnection(chuoiketnoi);
            ganMang();
            LoadCombobox();
            LoadData();
            doimau(0);

            checkTinhTong = false;
        }
        void LoadCombobox()         //Load tên nguyên liệu
        {
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            sql = @"Select NguyenLieu FROM Ten_Nguyen_Lieu";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();   //Đọc dữ liệu Tên nguyên liệu

            DataTable dt = new DataTable();
            dt.Load(docdulieu);
            cbo_NguyenLieu.DataSource = dt;
            cbo_NguyenLieu.ValueMember = "NguyenLieu";
            ketnoi.Close();
        }

        void LoadData()         //Load dữ liệu xuống bảng
        {
            if(ketnoi.State == ConnectionState.Closed)
               ketnoi.Open();
            sql = @"Select Nguyen_Lieu,Khoi_Luong,TT_Can,Tong_KL FROM "+txt_SoHieuCt.Text+"";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();   //Đọc dữ liệu Tên nguyên liệu
            int i = 0;
            while (docdulieu.Read())
            {
                if (i<=SoSilo)
                {
                    txt_NLSilo[i].Text = docdulieu[0].ToString();
                    txt_KLSilo[i].Text = docdulieu[1].ToString();
                    txt_TTCan[i].Text = docdulieu[2].ToString();
                }
                if(i==0)
                {
                    txt_Tong.Text = docdulieu[3].ToString();
                }    
                i++;
            }
            ketnoi.Close();
        }
        private void ganMang()      //Tạo các mảng chứa số,nguyên liệu, khối lượng, thứ tự cân Silo
        {
            txt_Silo = new TextBox[] {txt_Silo1,txt_Silo2,txt_Silo3,txt_Silo4,txt_Silo5,txt_Silo6,txt_Silo7,
            txt_Silo8,txt_Silo9,txt_Silo10,txt_Silo11,txt_Silo12,txt_Silo13,txt_Silo14,txt_Silo15,txt_SiloThem};

            txt_NLSilo = new TextBox[] {txt_NLSilo1,txt_NLSilo2,txt_NLSilo3,txt_NLSilo4,txt_NLSilo5,txt_NLSilo6,txt_NLSilo7,
            txt_NLSilo8,txt_NLSilo9,txt_NLSilo10,txt_NLSilo11,txt_NLSilo12,txt_NLSilo13,txt_NLSilo14,txt_NLSilo15,txt_NLThemTay};

            txt_KLSilo = new TextBox[] {txt_KLSilo1,txt_KLSilo2,txt_KLSilo3,txt_KLSilo4,txt_KLSilo5,txt_KLSilo6,txt_KLSilo7,
            txt_KLSilo8,txt_KLSilo9,txt_KLSilo10,txt_KLSilo11,txt_KLSilo12,txt_KLSilo13,txt_KLSilo14,txt_KLSilo15,txt_KLThem};

            txt_TTCan = new TextBox[] {txt_TTCan1,txt_TTCan2,txt_TTCan3,txt_TTCan4,txt_TTCan5,txt_TTCan6,txt_TTCan7,
            txt_TTCan8,txt_TTCan9,txt_TTCan10,txt_TTCan11,txt_TTCan12,txt_TTCan13,txt_TTCan14,txt_TTCan15,txt_TTCanThem};
        }
        private void doimau(int index)      //Đổi màu hàng khi click vào Silo, hàng nào đổi màu mới chỉnh sửa được
        {
            for (int i = 0; i <= SoSilo; i++)
            {
                if (i == index)
                {
                    txt_NLSilo[i].BackColor = Color.GreenYellow;
                    txt_KLSilo[i].BackColor = Color.GreenYellow;
                    txt_TTCan[i].BackColor = Color.GreenYellow;

                    if(index!=SoSilo)       //Không cho chỉnh sửa nguyên liệu thêm tay
                        txt_NLSilo[i].ReadOnly = false;
                    txt_KLSilo[i].ReadOnly = false;
                    txt_TTCan[i].ReadOnly = false;
                }
                else
                {
                    txt_NLSilo[i].BackColor = Color.White;
                    txt_KLSilo[i].BackColor = Color.White;
                    txt_TTCan[i].BackColor = Color.White;

                    txt_NLSilo[i].ReadOnly = true;
                    txt_KLSilo[i].ReadOnly = true;
                    txt_TTCan[i].ReadOnly = true;
                }
                if (index < SoSilo)
                    txt_ThuTuSilo.Text = (index + 1).ToString();
                else
                    txt_ThuTuSilo.Text = txt_SiloThem.Text;
            }
        }
        private void cbo_NguyenLieu_SelectedValueChanged(object sender, EventArgs e)    //Chọn nguyên liệu
        {
            if(SiloIndex >= 0 && SiloIndex < SoSilo)
                txt_NLSilo[SiloIndex].Text = cbo_NguyenLieu.SelectedValue.ToString();
        }

        #region ChonSilo
        private void txt_Silo1_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 0;
            doimau(SiloIndex);
        }

        private void txt_Silo2_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 1;
            doimau(SiloIndex);
        }

        private void txt_Silo3_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 2;
            doimau(SiloIndex);
        }

        private void txt_Silo4_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 3;
            doimau(SiloIndex);
        }

        private void txt_Silo5_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 4;
            doimau(SiloIndex);
        }

        private void txt_Silo6_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 5;
            doimau(SiloIndex);
        }

        private void txt_Silo7_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 6;
            doimau(SiloIndex);
        }

        private void txt_Silo8_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 7;
            doimau(SiloIndex);
        }

        private void txt_Silo9_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 8;
            doimau(SiloIndex);
        }

        private void txt_Silo10_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 9;
            doimau(SiloIndex);
        }

        private void txt_Silo11_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 10;
            doimau(SiloIndex);
        }

        private void txt_Silo12_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 11;
            doimau(SiloIndex);
        }

        private void txt_Silo13_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 12;
            doimau(SiloIndex);
        }

        private void txt_Silo14_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 13;
            doimau(SiloIndex);
        }

        private void txt_Silo15_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 14;
            doimau(SiloIndex);
        }

        private void txt_SiloThem_MouseClick(object sender, MouseEventArgs e)
        {
            SiloIndex = 15;
            doimau(SiloIndex);
        }
        #endregion ChonSilo

        private void btn_Tong_Click(object sender, EventArgs e)
        {
            checkTinhTong = true;
            for (int i = 0; i < SoSilo; i++)
            {
                if (txt_KLSilo[i].Text != "")
                    TongKL = TongKL + float.Parse(txt_KLSilo[i].Text);
            }
            if (txt_KLThem.Text != "")
                TongKL = TongKL + float.Parse(txt_KLThem.Text);
            txt_Tong.Text = TongKL.ToString();
            TongKL = 0;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(txt_Tong.Text == ""|checkTinhTong == false)
            {
                MessageBox.Show("Vui lòng tính tổng khối lượng trước khi lưu!"
                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult check1 = MessageBox.Show("Lưu những thay đổi về công thức " + txt_CongThuc.Text + " có số hiệu " + txt_SoHieuCt.Text + "",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check1 == DialogResult.Cancel)
                return;
            if(ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            sql = @"TRUNCATE TABLE " + txt_SoHieuCt.Text + "";        //Xóa dữ liệu trong bảng
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();

            //Thêm dữ liệu hàng đầu tiên ( có Tổng KL )
            sql = @"Insert Into " + txt_SoHieuCt.Text + "(Silo,Nguyen_Lieu,Khoi_Luong,TT_Can,Tong_KL) values (N'" + txt_Silo[0].Text + "'," +
                      "N'" + txt_NLSilo[0].Text + "',N'" + txt_KLSilo[0].Text + "',N'" + txt_TTCan[0].Text + "',N'"+txt_Tong.Text+"') ";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            //Thêm dữ liệu các hàng tiếp theo
            for (int i = 1; i <= SoSilo; i++)
            {
                sql = @"Insert Into " + txt_SoHieuCt.Text + "(Silo,Nguyen_Lieu,Khoi_Luong,TT_Can) values (N'" + txt_Silo[i].Text + "'," +
                      "N'" + txt_NLSilo[i].Text + "',N'" + txt_KLSilo[i].Text + "',N'" + txt_TTCan[i].Text + "') ";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            ketnoi.Close();
            LoadData();

            DialogResult check2 = MessageBox.Show("Đã lưu dữ liệu công thức "+txt_CongThuc.Text+" có số hiệu "+txt_SoHieuCt.Text+"",
                "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(check2 == DialogResult.OK)
                checkTinhTong = false;      //Phục vụ check cho lần sửa công thức tiếp theo
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            frm_KhaiBaoCt frm = new frm_KhaiBaoCt();
            frm.Show();
            this.Close();
        }
    
    }
}
