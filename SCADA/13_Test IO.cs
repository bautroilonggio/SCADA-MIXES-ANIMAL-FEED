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
using S7.Net;
using SymbolFactoryDotNet;
using SCADA;

namespace BTL
{
    public partial class frm_Kiemtravaora : Form
    {
        public frm_Kiemtravaora()
        {
            InitializeComponent();
        }

        PLC_Command PLC_Com = new PLC_Command();
        StandardControl[] DenSilo;       //Đèn trên mỗi Silo
        StandardControl[] Silo;       //Silo

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            txt_ThoiGian.Text = DateTime.Now.ToString();
        }

        private void ChuKyQuet_Tick(object sender, EventArgs e)
        {
            if(SCADA.ThongTin.checkKetNoi == true)
            {
                lbl_TrangThaiKetNoi.Text = "Đã kết nối cân";
                lbl_TrangThaiKetNoi.ForeColor = Color.White;
                btn_ChoPhepCan.Enabled = true;
                btn_ChoXaCan.Enabled = true;

                for (int i = 0; i <= SCADA.ThongTin.SoSilo; i++)
                {
                    Silo[i].Enabled = true;
                    DenSilo[i].Enabled = true;
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
                btn_ChoPhepCan.Enabled = false;
                btn_ChoXaCan.Enabled = false;
                for (int i = 0; i <= SCADA.ThongTin.SoSilo; i++)
                {
                    Silo[i].Enabled = false;
                    DenSilo[i].Enabled = false;
                }
            }
        }

        // Chương trình con hiển thị trạng thái các đèn
        private void Den(StandardControl ob, bool value)
        {
            if (value == true)
                ob.DiscreteValue1 = true;
            else
                ob.DiscreteValue1 = false;
        }

        private void ganMang()      //Tạo các mảng chứa Silo và Đèn báo của chúng
        {
            DenSilo = new StandardControl[] { Den1, Den2, Den3, Den4, Den5, Den6, Den7, Den8, Den9, Den10,
            Den11, Den12, Den13, Den14, Den15, DenThemTay };

            Silo = new StandardControl[] { Silo1, Silo2, Silo3, Silo4, Silo5, Silo6, Silo7, Silo8, Silo9, Silo10,
            Silo11, Silo12, Silo13, Silo14, Silo15, SiloThemTay};

        }

        private void frm_Kiemtravaora_Load(object sender, EventArgs e)
        {
            ganMang();
            ThoiGian.Start();
            ChuKyQuet.Start();

            SCADA.ThongTin.checkTestIO = true;
        }

        #region ChonSilo
        private void Silo1_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M0.1", 1);
            SCADA.ThongTin.plc.Write("M0.1", 0);
        }

        private void Silo2_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M0.2", 1);
            SCADA.ThongTin.plc.Write("M0.2", 0);
        }

        private void Silo3_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M0.3", 1);
            SCADA.ThongTin.plc.Write("M0.3", 0);
        }

        private void Silo4_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M0.4", 1);
            SCADA.ThongTin.plc.Write("M0.4", 0);
        }

        private void Silo5_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M0.5", 1);
            SCADA.ThongTin.plc.Write("M0.5", 0);
        }

        private void Silo6_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M0.6", 1);
            SCADA.ThongTin.plc.Write("M0.6", 0);
        }

        private void Silo7_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M0.7", 1);
            SCADA.ThongTin.plc.Write("M0.7", 0);
        }

        private void Silo8_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M1.0", 1);
            SCADA.ThongTin.plc.Write("M1.0", 0);
        }

        private void Silo9_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M1.1", 1);
            SCADA.ThongTin.plc.Write("M1.1", 0);
        }

        private void Silo10_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M1.2", 1);
            SCADA.ThongTin.plc.Write("M1.2", 0);
        }

        private void Silo11_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M1.3", 1);
            SCADA.ThongTin.plc.Write("M1.3", 0);
        }

        private void Silo12_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M1.4", 1);
            SCADA.ThongTin.plc.Write("M1.4", 0);
        }

        private void Silo13_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M1.5", 1);
            SCADA.ThongTin.plc.Write("M1.5", 0);
        }

        private void Silo14_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M1.6", 1);
            SCADA.ThongTin.plc.Write("M1.6", 0);
        }

        private void Silo15_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M1.7", 1);
            SCADA.ThongTin.plc.Write("M1.7 ", 0);
        }

        private void SiloThemTay_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M2.3", 1);
            SCADA.ThongTin.plc.Write("M2.3", 0);
        }

        #endregion ChonSilo

        private void btn_ChoPhepCan_Click(object sender, EventArgs e)
        {
            if (Den1.DiscreteValue1 | Den2.DiscreteValue1 | Den3.DiscreteValue1 | Den4.DiscreteValue1 | Den5.DiscreteValue1 |
                Den6.DiscreteValue1 | Den7.DiscreteValue1 | Den8.DiscreteValue1 | Den9.DiscreteValue1)
            {
                SCADA.ThongTin.plc.Write("M2.1", 1);
                SCADA.ThongTin.plc.Write("M2.1", 0);
            }
            else if (Den10.DiscreteValue1 | Den11.DiscreteValue1 | Den12.DiscreteValue1 | Den13.DiscreteValue1 |
                Den14.DiscreteValue1 | Den15.DiscreteValue1)
            {
                SCADA.ThongTin.plc.Write("M2.4", 1);
                SCADA.ThongTin.plc.Write("M2.4", 0);
            }
            else if (DenThemTay.DiscreteValue1 == true)
            {
                SCADA.ThongTin.plc.Write("M2.5", 1);
                SCADA.ThongTin.plc.Write("M2.5", 0);
            }
        }

        private void btn_ChoXaCan_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.plc.Write("M2.2", 1);
            SCADA.ThongTin.plc.Write("M2.2", 0);
        }

        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            frm_DiaChiIP frm = new frm_DiaChiIP();
            frm.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            frm_Home frm = new frm_Home();
            frm.Show();
            this.Close();
        }

        
    }
}
