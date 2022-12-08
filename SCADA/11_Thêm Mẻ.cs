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
    public partial class frm_ThemMe : Form
    {
        public frm_ThemMe()
        {
            InitializeComponent();
        }

        //Phương thức nhập
        private void txt_SoMeThem_KeyPress(object sender, KeyPressEventArgs e)  //Chỉ nhập được số tự nhiên
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;       //Bỏ qua những cú pháp không hợp lệ
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_SoMeThem.Text != "")
                SCADA.ThongTin.TongSoMe = SCADA.ThongTin.TongSoMe + int.Parse(txt_SoMeThem.Text);
            MessageBox.Show("Đã lưu số mẻ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
