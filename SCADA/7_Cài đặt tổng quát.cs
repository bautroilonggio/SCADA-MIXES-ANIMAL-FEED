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
using BTL;

namespace SCADA
{
    public partial class frm_CaiDatTong : Form
    {
        public frm_CaiDatTong()
        {
            InitializeComponent();
        }

        #region PhuongThucNhap
        private void txt_TongSoMt_KeyPress(object sender, KeyPressEventArgs e)   //Chỉ cho nhập số tự nhiên
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;       //Bỏ qua những cú pháp không hợp lệ
        }

        private void txt_ThoiGianTron_KeyPress(object sender, KeyPressEventArgs e)  //Chỉ cho nhập số thực không âm
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txt_ThoiGianXa_KeyPress(object sender, KeyPressEventArgs e)    //Chỉ cho nhập số thực không âm
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

        float TgTronMin = 0, TgTronMax = 1000;
        float TgXaMin = 0, TgXaMax = 1000;

        private void frm_CaiDatTong_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            LoadCombobox();
            
            if (SCADA.ThongTin.TongSoMe>0)    //Load lại thông tin đã nhập trước đó (nếu có)
            {
                cbo_SoHieuCt.Text = SCADA.ThongTin.soHieuCt;
                txt_ThoiGianTron.Text = SCADA.ThongTin.TgTron.ToString();
                txt_ThoiGianXa.Text = SCADA.ThongTin.TgXaTron.ToString();
                txt_TongSoMt.Text = SCADA.ThongTin.TongSoMe.ToString();
            }
        }

        void LoadCombobox()         //Load Số hiệu công thức
        {
            ketnoi.Open();
            sql = @"Select SoHieu FROM Khai_Bao_Ct";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();   //Đọc dữ liệu Số hiệu công thức

            while(docdulieu.Read())
            {
                cbo_SoHieuCt.Items.Add(docdulieu["SoHieu"].ToString().ToUpper());
            }    
            ketnoi.Close();
        }

        void LoadData()         //Load dữ liệu khối lượng thêm tay và tổng khối lượng mẻ
        {
            ketnoi.Open();
            sql = @"Select Khoi_Luong,Tong_KL FROM "+cbo_SoHieuCt.Text+"";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            int i = 0;
            while (docdulieu.Read())
            {
                if (i == 0)     //Lấy dữ liệu hàng đầu tiên
                    txt_KLMe.Text = docdulieu[1].ToString();
                if (i == SCADA.ThongTin.SoSilo)     //Lấy dữ liệu hàng cuối cùng
                    txt_KLThem.Text = docdulieu[0].ToString();
                i++;
            }
            ketnoi.Close();
        }

        private void cbo_SoHieuCt_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbo_SoHieuCt.SelectedIndex >= 0)    
                LoadData();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (cbo_SoHieuCt.Text == "")//Nếu chưa chọn số hiệu công thức
            {
                MessageBox.Show("Bạn chưa chọn Công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                cbo_SoHieuCt.Focus();
                return;
            }
            if (txt_TongSoMt.Text == "")
            {
                MessageBox.Show("Bạn chưa điền Tổng số mẻ trộn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TongSoMt.Focus();
                return;
            }
            if (int.Parse(txt_TongSoMt.Text) == 0)
            {
                MessageBox.Show("Tổng số mẻ trộn phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TongSoMt.Focus();
                return;
            }
            if (txt_ThoiGianTron.Text == "")
            {
                MessageBox.Show("Bạn chưa điền Thời gian trộn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ThoiGianTron.Focus();
                return;
            }
            if(float.Parse(txt_ThoiGianTron.Text) < TgTronMin )
            {
                MessageBox.Show("Thời gian trộn ít nhất là "+TgTronMin.ToString()+"(s)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ThoiGianTron.Focus();
                txt_ThoiGianTron.Text = TgTronMin.ToString();
                return;
            }
            if (float.Parse(txt_ThoiGianTron.Text) > TgTronMax)
            {
                MessageBox.Show("Thời gian trộn lớn nhất là " + TgTronMax.ToString() + "(s)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ThoiGianTron.Focus();
                txt_ThoiGianTron.Text = TgTronMax.ToString();
                return;
            }
            if (txt_ThoiGianXa.Text == "")
            {
                MessageBox.Show("Bạn chưa điền Thời gian xả trộn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ThoiGianXa.Focus();
                return;
            }
            if (float.Parse(txt_ThoiGianXa.Text) < TgXaMin)
            {
                MessageBox.Show("Thời gian xả trộn ít nhất là " + TgXaMin.ToString() + "(s)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ThoiGianXa.Focus();
                txt_ThoiGianXa.Text = TgXaMin.ToString();
                return;
            }
            if (float.Parse(txt_ThoiGianXa.Text) > TgXaMax)
            {
                MessageBox.Show("Thời gian xả trộn lớn nhất là " + TgTronMax.ToString() + "(s)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ThoiGianXa.Focus();
                txt_ThoiGianXa.Text = TgXaMax.ToString();
                return;
            }

            DialogResult check = MessageBox.Show("Lưu thông tin cài đặt tổng quát hệ thống ?", "Xác nhận",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (check == DialogResult.OK)
            {
                SCADA.ThongTin.soHieuCt = cbo_SoHieuCt.Text;
                SCADA.ThongTin.TongSoMe = int.Parse(txt_TongSoMt.Text);
                SCADA.ThongTin.TgTron = float.Parse(txt_ThoiGianTron.Text);
                SCADA.ThongTin.TgXaTron = float.Parse(txt_ThoiGianXa.Text);
                SCADA.ThongTin.KL_Them = float.Parse(txt_KLThem.Text);
                SCADA.ThongTin.KL_Me = float.Parse(txt_KLMe.Text);
            }
            MessageBox.Show("Đã lưu cài đặt tổng quát", "Thông báo", MessageBoxButtons.OK);
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            if(frm_Home.ThongTin.checkCaiDatTongQuat == true)
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
