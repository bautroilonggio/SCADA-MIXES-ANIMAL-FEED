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
    public partial class frm_KhaiBaoCt : Form
    {
        public frm_KhaiBaoCt()
        {
            InitializeComponent();
        }

        public class ThongTin       //Lưu thông tin về công thức
        {
            static public string tenCt, soHieuCt;
        }

        string chuoiketnoi = @"Data Source=LINK\KHACLINH;Initial Catalog=SCADA;Integrated Security=True"; 
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        string soHieu;

        private void frm_KhaiBaoCt_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            LoadData();
        }

        public void LoadData()      //Load dữ liệu từ bảng Khai báo công thức trên CSDL xuống listview
        {
            lsv_CongThuc.Items.Clear();
            if(ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            sql = @"Select TenCongThuc,SoHieu FROM Khai_Bao_Ct";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            while (docdulieu.Read())
            {
                ListViewItem CongThuc = new ListViewItem();
                CongThuc.Text = docdulieu[0].ToString();
                CongThuc.SubItems.Add(docdulieu[1].ToString());
                lsv_CongThuc.Items.Add(CongThuc);
            }
            ketnoi.Close();
        }

        private void lsv_CongThuc_Click(object sender, EventArgs e)
        {
            //Đọc dữ liệu hàng được chọn
            txt_CongThuc.Text = lsv_CongThuc.SelectedItems[0].SubItems[0].Text;
            txt_SoHieuCt.Text = lsv_CongThuc.SelectedItems[0].SubItems[1].Text;
            soHieu = txt_SoHieuCt.Text;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (rbn_ThemCt.Checked)
            {
                if(txt_CongThuc.Text.Length == 0&&txt_SoHieuCt.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập Tên và Sô hiệu công thức");
                    return;
                }    
                if (txt_CongThuc.Text.Length == 0)
                {
                    MessageBox.Show("Bạn nhập thiếu tên Công thức rồi");
                    return;
                }
                if (txt_SoHieuCt.Text.Length == 0)
                {
                    MessageBox.Show("Bạn nhập thiếu Số hiệu công thức rồi");
                    return;
                }
                foreach(ListViewItem items in lsv_CongThuc.Items)
                {
                    if (items.SubItems[1].Text == txt_SoHieuCt.Text.Trim())
                    {
                        MessageBox.Show("Số hiệu công thức đã tồn tại");
                        return;
                    }
                }
                //Thêm hàng mới vào bảng Khai báo công thức
                lsv_CongThuc.Items.Clear();
                ketnoi.Open();
                sql = @"Insert Into Khai_Bao_Ct(TenCongThuc, SoHieu) values (N'" + txt_CongThuc.Text + "',N'" + txt_SoHieuCt.Text + "')";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();
                LoadData();

                //Tạo bảng mới với tên là số hiệu công thức luôn
                ketnoi.Open();
                sql = @"CREATE TABLE "+txt_SoHieuCt.Text+" (Silo ntext,Nguyen_Lieu nvarchar(MAX),Khoi_Luong float,TT_Can ntext,Tong_KL float)";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();

                //Thông báo
                MessageBox.Show("Đã thêm công thức. Vui lòng cài đặt công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Truyền thông tin về công thức
                ThongTin.tenCt = txt_CongThuc.Text;
                ThongTin.soHieuCt = txt_SoHieuCt.Text;

                //Mở form Cài đặt công thức và đóng form này đi
                frm_CaiDatCt frm = new frm_CaiDatCt();
                frm.Show();
                this.Hide();
            }
            if (rbn_SuaCt.Checked)
            {
                if (lsv_CongThuc.SelectedItems.Count > 0)
                {
                    //Lưu thông tin về công thức để truyền sang các form cài đặt công thức
                    ThongTin.tenCt = txt_CongThuc.Text;
                    ThongTin.soHieuCt = txt_SoHieuCt.Text;

                    foreach (ListViewItem items in lsv_CongThuc.Items)
                    {
                        //Nếu không sửa tên và số hiệu, mà chỉ sửa thông tin cài đặt công thức
                        if (items.SubItems[0].Text==txt_CongThuc.Text.Trim()&&items.SubItems[1].Text==txt_SoHieuCt.Text.Trim())
                        {
                            frm_CaiDatCt frm1 = new frm_CaiDatCt();  //Mở form Cài đặt công thức
                            frm1.Show();
                            this.Hide();
                            return;
                        }
                    }
                    lsv_CongThuc.Items.Clear();
                    //Gửi thông tin đến bảng Khai bao công thức
                    ketnoi.Open();
                    sql = @"Update Khai_Bao_Ct set TenCongThuc=N'" + txt_CongThuc.Text + "',SoHieu=N'" + txt_SoHieuCt.Text + "' WHERE (SoHieu=N'"+soHieu+"')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    LoadData();

                    //Đổi tên bảng công thức silo
                    ketnoi.Open();
                    sql = @"SP_RENAME "+soHieu.Trim()+","+txt_SoHieuCt.Text+"";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    
                    frm_CaiDatCt frm2 = new frm_CaiDatCt();  //Mở form Cài đặt công thức
                    frm2.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Bạn chưa chọn mục cần sửa");
            }
            if (rbn_XoaCt.Checked)
            {
                DialogResult check = MessageBox.Show("Bạn muốn xóa công thức " + txt_CongThuc.Text + " có số hiệu " + txt_SoHieuCt.Text + "",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (check == DialogResult.Cancel)
                    return;
                if (lsv_CongThuc.SelectedItems.Count > 0)
                {
                    lsv_CongThuc.Items.Clear();
                    //Xóa hàng được chọn
                    ketnoi.Open();
                    sql = @"Delete FROM Khai_Bao_Ct WHERE (SoHieu=N'" +soHieu+ "')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    LoadData();

                    //Xóa bảng công thức đó trong CSDL
                    ketnoi.Open();
                    sql = @"DROP TABLE " + txt_SoHieuCt.Text + "";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();

                    //Thông báo
                    MessageBox.Show("Đã xóa công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Bạn chưa chọn mục cần xóa");
            }
        }
        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            frm_Home frm = new frm_Home();
            frm.Show(); //Mở form Home

            this.Close();    //Đóng form này đi
        }
    }
}
