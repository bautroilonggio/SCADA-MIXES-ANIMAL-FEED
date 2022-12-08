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
    public partial class frm_NguyenLieu : Form
    {
        int i,j;
        public frm_NguyenLieu()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=LINK\KHACLINH;Initial Catalog=SCADA;Integrated Security=True"; 
        string sql;             
        SqlConnection ketnoi;   
        SqlCommand thuchien;    
        SqlDataReader docdulieu;    

        private void frm_NguyenLieu_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);    //Mở kết nối đến SQL Server
            hienthi();  //Hiển thị bảng nguyên liệu
            i = lsv_NguyenLieu.Items.Count; 
        }

        public void hienthi()
        {
            lsv_NguyenLieu.Items.Clear();
            ketnoi.Open();
            sql = "Select STT,NguyenLieu FROM Ten_Nguyen_Lieu";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            while(docdulieu.Read())
            {
                ListViewItem NguyenLieu = new ListViewItem();
                NguyenLieu.Text = docdulieu[0].ToString();
                NguyenLieu.SubItems.Add(docdulieu[1].ToString());
                lsv_NguyenLieu.Items.Add(NguyenLieu);
            }
            ketnoi.Close();
        }

        private void lsv_NguyenLieu_Click(object sender, EventArgs e)
        {
            //Đọc dữ liệu hàng được chọn
            txt_NguyenLieu.Text = lsv_NguyenLieu.SelectedItems[0].SubItems[1].Text;

            //Đọc số hàng
            j = int.Parse(lsv_NguyenLieu.SelectedItems[0].SubItems[0].Text);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_NguyenLieu.Text.Length > 0)
            {
                lsv_NguyenLieu.Items.Clear();
                ketnoi.Open();
                i++;
                sql = @"Insert Into Ten_Nguyen_Lieu(STT, NguyenLieu) values (N'" + i.ToString() + "',N'" + txt_NguyenLieu.Text + "')";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();
                hienthi();
            }
            else
                MessageBox.Show("Bạn nhập thiếu rồi");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lsv_NguyenLieu.SelectedItems.Count > 0)
            {
                lsv_NguyenLieu.Items.Clear();
                ketnoi.Open();
                sql = @"Update Ten_Nguyen_Lieu set NguyenLieu=N'" + txt_NguyenLieu.Text + "' WHERE (STT=N'" + j.ToString() + "')";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();
                hienthi();
            }
            else
                MessageBox.Show("Bạn chưa chọn mục cần sửa");
        }
        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            if (lsv_NguyenLieu.SelectedItems.Count > 0)
            {
                lsv_NguyenLieu.Items.Clear();
                ketnoi.Open();
                //Nếu xóa hàng ở giữa
                if (j < i)
                {
                    //Xóa hàng được chọn
                    sql = @"Delete FROM Ten_Nguyen_Lieu WHERE (STT=N'" + j.ToString() + "')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    //Lùi STT các hàng phía trên lại 1 đơn vị
                    for (int a = j - 1; a < i; a++)
                    {
                        int dem = a + 1;
                        sql = @"Update Ten_Nguyen_Lieu set STT=N'" + a.ToString() + "' WHERE (STT=N'" + dem.ToString() + "')";
                        thuchien = new SqlCommand(sql, ketnoi);
                        thuchien.ExecuteNonQuery();
                    }
                }
                else
                {
                    //Xóa hàng được chọn
                    sql = @"Delete FROM Ten_Nguyen_Lieu WHERE (STT=N'" + j.ToString() + "')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                }    
                ketnoi.Close();
                hienthi();  
                i--;
            }
            else
                MessageBox.Show("Bạn chưa chọn mục cần xóa");
        }
        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            frm_Home frm = new frm_Home();
            frm.Show(); //Mở form Home
            this.Close();    //Tắt form này đi
        }
    }
}
