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
using System.IO;

namespace BTL
{
    public partial class frm_SaoluuKhoiphuc : Form
    {
        public frm_SaoluuKhoiphuc()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=LINK\KHACLINH;Initial Catalog=SCADA;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        bool checkChonKhoiPhuc;

        private void frm_SaoluuKhoiphuc_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            LoadData();
        }

        private void lsv_file_Click(object sender, EventArgs e)
        {
            txt_ThuMuc.Text = lsv_file.SelectedItems[0].SubItems[1].Text;
            checkChonKhoiPhuc = true;
        }

        void LoadData()     //Load thông tin sao lưu xuống listview
        {
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            sql = @"Select * from Sao_Luu";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            lsv_file.Items.Clear();
            while (docdulieu.Read())
            {
                ListViewItem FileSaoLuu = new ListViewItem();
                FileSaoLuu.Text = docdulieu[0].ToString();
                FileSaoLuu.SubItems.Add(docdulieu[1].ToString());
                lsv_file.Items.Add(FileSaoLuu);
            }
            ketnoi.Close();
        }

        private void btn_ChonThuMuc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Hãy chọn thư mục chứa dữ liệu";
            fbd.ShowNewFolderButton = true; //Cho phép tạo thư mục mới
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;  //Thư mục khi mở lên là My Computer
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_ThuMuc.Text = fbd.SelectedPath;
            }
        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            string NgayGhi = DateTime.Now.ToShortDateString();
            string TenFile = txt_ThuMuc.Text + "\\Data" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + ".bak";

            DialogResult checkSaoLuu = MessageBox.Show("Bạn chắc chắn muốn sao lưu dữ liệu ?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (checkSaoLuu == DialogResult.OK)
            {
                //Nếu file sao lưu không bị trùng tên (tên gán với ngày sao lưu) thì mới gửi thông tin sao lưu lên CSDL
                FileInfo file = new FileInfo(TenFile);
                if (file.Exists == false)
                {
                    if (ketnoi.State == ConnectionState.Closed)
                        ketnoi.Open();
                    sql = @"Insert into Sao_Luu(NgayGhi,TenFile) values ('" + NgayGhi + "','" + TenFile + "')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                }

                //Sao lưu dữ liệu
                if (ketnoi.State == ConnectionState.Closed)
                    ketnoi.Open();
                sql = @"Backup database SCADA to disk = '" + TenFile + "' With Init";   //Sao lưu cho phép ghi đè nếu trùng tên
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();

                MessageBox.Show("Sao lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Load thông tin sao lưu xuống listview
                LoadData();
            }
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            if (checkChonKhoiPhuc == false)
                MessageBox.Show("Vui lòng chọn file dữ liệu tương ứng với ngày sao lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
            else
            {
                DialogResult checkKhoiPhuc = MessageBox.Show("Bạn chắc chắn muốn khôi phục dữ liệu ?", "Xác nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (checkKhoiPhuc == DialogResult.OK)
                {
                    if (ketnoi.State == ConnectionState.Closed)
                        ketnoi.Open();
                    sql = @"Restore database SCADA from disk = '" + txt_ThuMuc.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();

                    MessageBox.Show("Khôi phục dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkChonKhoiPhuc = false;
                }
            }
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            frm_Baocao frm = new frm_Baocao();
            frm.Show();
            this.Close();
        }

    }
}
