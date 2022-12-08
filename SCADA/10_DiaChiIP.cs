using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;

namespace SCADA
{
    public partial class frm_DiaChiIP : Form
    {
        public frm_DiaChiIP()
        {
            InitializeComponent();
        }

        //Chỉ điền được ký tự số và dấu chấm
        private void txt_DiaChiIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;       //Bỏ qua những cú pháp không hợp lệ
        }

        private void frm_DiaChiIP_Load(object sender, EventArgs e)
        {
            if (SCADA.ThongTin.DiaChiIP != "")
                txt_DiaChiIP.Text = SCADA.ThongTin.DiaChiIP;
        }

        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            SCADA.ThongTin.DiaChiIP = txt_DiaChiIP.Text;
            SCADA.ThongTin.plc = new Plc(CpuType.S71200, txt_DiaChiIP.Text, 0, 0);
            if (SCADA.ThongTin.plc.Open() == ErrorCode.NoError)
            {
                SCADA.ThongTin.checkKetNoi = true;
                MessageBox.Show("Kết nối thành công đến PLC S7-1200");
                //
                SCADA.ThongTin.plc.Write("M2.0", 1);
            }
            else
            {
                SCADA.ThongTin.checkKetNoi = false;
                MessageBox.Show("Kết nối đến PLC S7-1200 thất bại");
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
