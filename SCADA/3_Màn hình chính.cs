using BTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADA
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        public class ThongTin
        {
            static public bool checkCaiDatThoiGian;
            static public bool checkCaiDatTongQuat;
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            if(frm_DangNhap.ThongTin.TaiKhoan != "admin")
            {
                btn_NguyenLieu.BackColor = Color.Crimson;
                btn_NguyenLieu.Enabled = false;         //Vô hiệu nút nhấn
                btn_CongThuc.BackColor = Color.Crimson;
                btn_CongThuc.Enabled = false;
            }

            if (SCADA.ThongTin.checkTestIO == true)
                btn_Can.Enabled = true;
            else
                btn_Can.Enabled = false;
        }

        private void btn_NguyenLieu_Click(object sender, EventArgs e)
        {
            frm_NguyenLieu frm = new frm_NguyenLieu();
            frm.Show();

            this.Hide();
        }

        private void btn_CongThuc_Click(object sender, EventArgs e)
        {
            frm_KhaiBaoCt frm = new frm_KhaiBaoCt();
            frm.Show();

            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm = new frm_DangNhap();
            frm.Show();

            this.Close();
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            ThongTin.checkCaiDatTongQuat = true;
            frm_CaiDatTong frm = new frm_CaiDatTong();
            frm.Show();

            this.Hide();
        }

        private void btn_Can_Click(object sender, EventArgs e)
        {
            frm_CanTuDong frm = new frm_CanTuDong();
            frm.Show();
            this.Close();
        }

        private void btn_ThoiGian_Click(object sender, EventArgs e)
        {
            ThongTin.checkCaiDatThoiGian = true;
            frm_CatDatTg frm = new frm_CatDatTg();
            frm.Show();
            this.Close();
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            frm_Baocao frm = new frm_Baocao();
            frm.Show();
            this.Close();
        }

        private void btn_IO_Click(object sender, EventArgs e)
        {
            frm_Kiemtravaora frm = new frm_Kiemtravaora();
            frm.Show();
            this.Close();
        }
    }
}
