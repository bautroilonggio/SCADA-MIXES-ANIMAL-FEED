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

namespace BTL
{
    public partial class frm_CatDatTg : Form
    {
        public frm_CatDatTg()
        {
            InitializeComponent();
        }

        #region PhuongThucNhap
        private void txt_TgTreCanNL_KeyPress(object sender, KeyPressEventArgs e)    //Chỉ cho nhập số thực không âm
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;       //Bỏ qua những cú pháp không hợp lệ
        }

        private void txt_TgTreCanF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_TgTreFNghien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_TgTreNghienH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_TgTreHTron_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_TgBomDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }
        #endregion PhuongThucNhap

        private void frm_CatDatTg_Load(object sender, EventArgs e)
        {
            //Load lại thông tin đã cài đặt trước đó (nếu có)
            txt_TgTron.Text = SCADA.ThongTin.TgTron.ToString();
            txt_TgXaTron.Text = SCADA.ThongTin.TgXaTron.ToString();
            txt_TgTreCanNL.Text = SCADA.ThongTin.TgTreCanNL;
            txt_TgTreCanF.Text = SCADA.ThongTin.TgTreCanF;
            txt_TgTreFNghien.Text = SCADA.ThongTin.TgTreFNghien;
            txt_TgTreNghienH.Text = SCADA.ThongTin.TgTreNghienH;
            txt_TgTreHTron.Text = SCADA.ThongTin.TgTreHTron;
            txt_TgBomDau.Text = SCADA.ThongTin.TgBomDau;
        }

        private void btn_Luu_Click(object sender, EventArgs e)      //Lưu thông tin Cài đặt thời gian
        {
            if (txt_TgTreCanNL.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thời gian trễ cân nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TgTreCanNL.Focus();
                return;
            }
            if (txt_TgTreCanF.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thời gian trễ từ cân đến F1,F2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TgTreCanF.Focus();
                return;
            }
            if (txt_TgTreFNghien.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thời gian trễ từ F1,F2 đến máy nghiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TgTreFNghien.Focus();
                return;
            }
            if (txt_TgTreNghienH.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thời gian trễ từ máy nghiền đến H1,H2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TgTreNghienH.Focus();
                return;
            }
            if (txt_TgTreHTron.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thời gian trễ từ H1,H2 đến máy trộn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TgTreHTron.Focus();
                return;
            }

            DialogResult check = MessageBox.Show("Lưu thông tin cài đặt thời gian ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check == DialogResult.OK)
            {
                //Lưu thông tin cài đặt thời gian vào hệ thống
                SCADA.ThongTin.TgTreCanNL = txt_TgTreCanNL.Text;
                SCADA.ThongTin.TgTreCanF = txt_TgTreCanF.Text;
                SCADA.ThongTin.TgTreFNghien = txt_TgTreFNghien.Text;
                SCADA.ThongTin.TgTreNghienH = txt_TgTreNghienH.Text;
                SCADA.ThongTin.TgTreHTron = txt_TgTreHTron.Text;
                SCADA.ThongTin.TgBomDau = txt_TgBomDau.Text;
            }
            MessageBox.Show("Đã lưu cài đặt thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            if (frm_Home.ThongTin.checkCaiDatThoiGian == true)
            {
                frm_Home frm = new frm_Home();
                frm.Show();
                this.Close();
            }
            else
            {
                frm_CanTuDong frm = new frm_CanTuDong();
                frm.Show();
                this.Close();
            }
        }
    }
}
