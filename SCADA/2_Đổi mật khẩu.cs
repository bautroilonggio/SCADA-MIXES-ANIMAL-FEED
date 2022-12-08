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
    public partial class frm_DoiMatKhau : Form
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=LINK\KHACLINH;Initial Catalog=SCADA;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;

        private void frm_changepass_Load(object sender, EventArgs e)
        {
            txt_MatKhauCu.UseSystemPasswordChar = false;
            txt_MatKhauMoi.UseSystemPasswordChar = false;
            txt_MatKhauXacNhan.UseSystemPasswordChar = false;

            ketnoi = new SqlConnection(chuoiketnoi);
            LoadTaiKhoan();
        }

        void LoadTaiKhoan()         //Load tên tài khoản vào combobox
        {
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            sql = @"Select Tai_Khoan FROM Dang_Nhap";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();   //Đọc dữ liệu Số hiệu công thức

            while (docdulieu.Read())
            {
                cbo_TaiKhoan.Items.Add(docdulieu["Tai_Khoan"].ToString().ToUpper());
            }
            ketnoi.Close();
        }

        private void pb_HienMatKhauCu_Click(object sender, EventArgs e)
        {
            txt_MatKhauCu.UseSystemPasswordChar = true;
            pb_HienMatKhauCu.Visible = false;
            pb_AnMatKhauCu.Visible = true;
        }

        private void pb_AnMatKhauCu_Click(object sender, EventArgs e)
        {
            txt_MatKhauCu.UseSystemPasswordChar = false;
            pb_AnMatKhauCu.Visible = false;
            pb_HienMatKhauCu.Visible = true;
        }

        private void pb_HienMatKhauMoi_Click(object sender, EventArgs e)
        {
            txt_MatKhauMoi.UseSystemPasswordChar = true;
            pb_HienMatKhauMoi.Visible = false;
            pb_AnMatKhauMoi.Visible = true;
        }

        private void pb_AnMatKhauMoi_Click(object sender, EventArgs e)
        {
            txt_MatKhauMoi.UseSystemPasswordChar = false;
            pb_AnMatKhauMoi.Visible = false;
            pb_HienMatKhauMoi.Visible = true;
        }

        private void pb_HienMatKhauXacNhan_Click(object sender, EventArgs e)
        {
            txt_MatKhauXacNhan.UseSystemPasswordChar = true;
            pb_HienMatKhauXacNhan.Visible = false;
            pb_AnMatKhauXacNhan.Visible = true;
        }

        private void pb_AnMatKhauXacNhan_Click(object sender, EventArgs e)
        {
            txt_MatKhauXacNhan.UseSystemPasswordChar = false;
            pb_AnMatKhauXacNhan.Visible = false;
            pb_HienMatKhauXacNhan.Visible = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (cbo_TaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_TaiKhoan.Focus();          //Đặt con trỏ vào ô chọn tài khoản
                return;
            }

            if (txt_MatKhauCu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhauCu.Focus();          //Đặt con trỏ vào ô nhập mật khẩu cũ
                return;
            }

            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            sql = @"Select *from Dang_Nhap Where Tai_Khoan=N'" + cbo_TaiKhoan.Text + "'and Mat_Khau=N'" + txt_MatKhauCu.Text + "'";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            if (docdulieu.Read())
            {
                if (txt_MatKhauMoi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_MatKhauMoi.Focus();
                }
                else
                {
                    if (txt_MatKhauXacNhan.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_MatKhauXacNhan.Focus();
                    }
                    else
                    {
                        if (txt_MatKhauMoi.Text != txt_MatKhauXacNhan.Text)
                        {
                            MessageBox.Show("Mật khẩu mới và Mật khẩu xác nhận không trùng nhau",
                                  "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_MatKhauXacNhan.Text = "";
                            txt_MatKhauXacNhan.Focus();
                        }
                        else
                        {
                            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu tài khoản " + cbo_TaiKhoan.Text + "",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (check == DialogResult.Yes)
                            {
                                docdulieu.Close();
                                sql = @"Update Dang_Nhap set Mat_Khau=N'" + txt_MatKhauMoi.Text + "' Where (Tai_Khoan=N'" + cbo_TaiKhoan.Text + "')";
                                thuchien = new SqlCommand(sql, ketnoi);
                                thuchien.ExecuteNonQuery();

                                MessageBox.Show("Đã đổi mật khẩu tài khoản " + cbo_TaiKhoan.Text + "",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                txt_MatKhauCu.Text = "";
                                txt_MatKhauMoi.Text = "";
                                txt_MatKhauXacNhan.Text = "";
                                ketnoi.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhauCu.Text = "";
                txt_MatKhauCu.Focus();
            }
            ketnoi.Close();
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm = new frm_DangNhap();
            frm.Show();
            this.Close();
        }
    }
}
