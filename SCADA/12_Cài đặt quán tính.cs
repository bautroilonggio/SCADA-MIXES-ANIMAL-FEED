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
    public partial class frm_CaiDatFine : Form
    {
        public frm_CaiDatFine()
        {
            InitializeComponent();
        }

        //Chỉ nhập được số thực không âm
        private void txt_QuanTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;       //Bỏ qua những cú pháp không hợp lệ
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
