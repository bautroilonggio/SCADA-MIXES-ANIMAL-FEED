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
using S7.Net.Types;

namespace SCADA
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        public class ThongTin
        {
            static public string TaiKhoan, MatKhau;
        }

        string chuoiketnoi = @"Data Source=LINK\KHACLINH;Initial Catalog=SCADA;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int SoLanBamDangNhap = 0, Giay = 30, SoLanDangNhapSai = 5;

        private void DemNguoc_Tick(object sender, EventArgs e)
        {
            Giay--;
            if (Giay >= 10)
                lbl_Giay.Text = Giay.ToString();
            else
                lbl_Giay.Text = "0" + Giay.ToString() + "";
            if (Giay == 0)
            {
                btn_DangNhap.Enabled = true;
                lbl_ThongBaoDN.Visible = false;
                lbl_Giay.Visible = false;
                lbl_s.Visible = false;
                Giay = 30;
                SoLanBamDangNhap = 0;
                DemNguoc.Stop();
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = false;      //Ẩn mật khẩu

            ketnoi = new SqlConnection(chuoiketnoi);
            lbl_ThongBaoDN.Visible = false;
            lbl_Giay.Visible = false;
            lbl_s.Visible = false;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text.Length == 0 && txt_MatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa điền tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TaiKhoan.Focus();       //Đặt con trỏ vào mục tài khoản
                return;
            }
            if (txt_TaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TaiKhoan.Focus();
                return;
            }
            if (txt_MatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhau.Focus();
                return;
            }
            ketnoi.Open();
            sql = @"Select *from Dang_Nhap Where Tai_Khoan=N'" + txt_TaiKhoan.Text + "'and Mat_Khau=N'" + txt_MatKhau.Text + "'";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            if (docdulieu.Read())
            {
                SoLanBamDangNhap = 0;
                // Thông báo đăng nhập với quyền tương ứng
                MessageBox.Show("Đăng nhập thành công với quyền " + txt_TaiKhoan.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Lưu thông tin đăng nhập
                ThongTin.TaiKhoan = txt_TaiKhoan.Text;
                ThongTin.MatKhau = txt_MatKhau.Text;
                // Mở màn hình chính
                frm_Home frm = new frm_Home();
                frm.Show();

                this.Hide();
            }
            else
            {
                SoLanBamDangNhap++;
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TaiKhoan.Text = "";
                txt_MatKhau.Text = "";
                txt_TaiKhoan.Focus();
            }
            ketnoi.Close();
            if (SoLanBamDangNhap == SoLanDangNhapSai)
            {
                MessageBox.Show("Đăng nhập " + SoLanBamDangNhap + " lần không thành công, vui lòng đăng nhập lại sau " + Giay + " (s)",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_DangNhap.Enabled = false;
                lbl_ThongBaoDN.Visible = true;
                lbl_Giay.Visible = true;
                lbl_s.Visible = true;
                DemNguoc.Start();
            }
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau frm = new frm_DoiMatKhau();
            frm.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?"
                , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
                //
                if(SCADA.ThongTin.checkKetNoi == true)
                    SCADA.ThongTin.plc.Write("M2.0", 0);
            }
        }

        private void pb_HienMatKhau_Click(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = true;
            pb_HienMatKhau.Visible = false;
            pb_AnMatKhau.Visible = true;
        }

        private void pb_AnMatKhau_Click(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = false;
            pb_AnMatKhau.Visible = false;
            pb_HienMatKhau.Visible = true;
        }
    }
}
