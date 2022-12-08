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
using SCADA;

namespace BTL
{
    public partial class frm_Baocao : Form
    {
        public frm_Baocao()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=LINK\KHACLINH;Initial Catalog=SCADA;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        DataSet ds = new DataSet();
        DataRow row;

        public DateTime BeginTime, EndTime;

        private void frm_Baocao_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            cbo_tenNL.Text = "[ALL]";
            cbo_tenNL.Items.Add("[ALL]");
            cbo_SoHieuCt.Text = "[ALL]";
            cbo_SoHieuCt.Items.Add("[ALL]");
            cbo_tenNL.Enabled = false;
            cbo_SoHieuCt.Enabled = false;
            txt_MeSo.Enabled = false;
            lbl_GioDau.Enabled = false;
            lbl_NgayDau.Enabled = false;
            lbl_Den.Enabled = false;
            lbl_GioCuoi.Enabled = false;
            lbl_NgayCuoi.Enabled = false;
            dtp_BeginDay.Enabled = false;
            dtp_EndDay.Enabled = false;
            dtp_BeginTime.Enabled = false;
            dtp_EndTime.Enabled = false;
            LoadNguyenLieu();
            LoadSoHieuCt();
        }

        void LoadNguyenLieu()
        {
            ketnoi.Open();
            sql = @"Select NguyenLieu FROM Ten_Nguyen_Lieu";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();   //Đọc dữ liệu nguyên liệu công thức

            while (docdulieu.Read())
            {
                cbo_tenNL.Items.Add(docdulieu["NguyenLieu"].ToString().ToUpper());
            }
            ketnoi.Close();
        }

        void LoadSoHieuCt()
        {
            ketnoi.Open();
            sql = "Select SoHieu FROM Khai_Bao_Ct";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();   //Đọc dữ liệu Số hiệu công thức

            while (docdulieu.Read())
            {
                cbo_SoHieuCt.Items.Add(docdulieu["SoHieu"].ToString().ToUpper());
            }
            ketnoi.Close();
        }

        public long QuyDoiThoiGian(DateTime date)        //Quy đổi thời gian về 1 số nguyên
        {
            int nam, thang, ngay, gio, phut, giay;
            nam = date.Year;
            thang = date.Month;
            ngay = date.Day;
            gio = date.Hour;
            phut = date.Minute;
            giay = date.Second;
            if(mnu_TheoNgay.Checked)
            {
                giay = 0;
                phut = 0;
                gio = 0;
            }    
            long ThoiGian = 0;
            ThoiGian = giay + 100 * phut + 10000 * gio + ngay * 1000000 + thang * 100000000 + nam * 10000000000;
            return ThoiGian;
        }

        #region LuaChonBaoCao
        private void mnu_TheoNgay_Click(object sender, EventArgs e)
        {
            mnu_TheoNgay.Checked = true;
            mnu_TheoKhoangTg.Checked = false;
            lbl_GioDau.Enabled = false;
            lbl_NgayDau.Enabled = true;
            lbl_Den.Enabled = false;
            lbl_GioCuoi.Enabled = false;
            lbl_NgayCuoi.Enabled = false;
            dtp_BeginDay.Enabled = true;
            dtp_EndDay.Enabled = false;
            dtp_BeginTime.Enabled = false;
            dtp_EndTime.Enabled = false;
        }

        private void mnu_TheoKhoangTg_Click(object sender, EventArgs e)
        {
            mnu_TheoNgay.Checked = false;
            mnu_TheoKhoangTg.Checked = true;
            lbl_GioDau.Enabled = true;
            lbl_NgayDau.Enabled = true;
            lbl_Den.Enabled = true;
            lbl_NgayCuoi.Enabled = true;
            lbl_GioCuoi.Enabled = true;
            dtp_BeginDay.Enabled = true;
            dtp_EndDay.Enabled = true;
            dtp_BeginTime.Enabled = true;
            dtp_EndTime.Enabled = true;
        }

        private void Mnu_TheoNL_Click(object sender, EventArgs e)
        {
            mnu_TheoNL.Checked = true;
            mnu_TheoCongThuc.Checked = false;
            mnu_TheoCongThucNL.Checked = false;
            mnu_TheoCongThucMe.Checked = false;
            mnu_ChiTiet.Checked = false;
            cbo_tenNL.Enabled = true;
            cbo_SoHieuCt.Enabled = false;
            txt_MeSo.Enabled = false;
        }

        private void mnu_TheoCongThuc_Click(object sender, EventArgs e)
        {
            mnu_TheoNL.Checked = false;
            mnu_TheoCongThuc.Checked = true;
            mnu_TheoCongThucNL.Checked = false;
            mnu_TheoCongThucMe.Checked = false;
            mnu_ChiTiet.Checked = false;
            cbo_tenNL.Enabled = false;
            cbo_SoHieuCt.Enabled = true;
            txt_MeSo.Enabled = false;
        }

        private void mnu_TheoCongThucNL_Click(object sender, EventArgs e)
        {
            mnu_TheoNL.Checked = false;
            mnu_TheoCongThuc.Checked = false;
            mnu_TheoCongThucNL.Checked = true;
            mnu_TheoCongThucMe.Checked = false;
            mnu_ChiTiet.Checked = false;
            cbo_tenNL.Enabled = true;
            cbo_SoHieuCt.Enabled = true;
            txt_MeSo.Enabled = false;
        }

        private void mnu_TheoCongThucMe_Click(object sender, EventArgs e)
        {
            mnu_TheoNL.Checked = false;
            mnu_TheoCongThuc.Checked = false;
            mnu_TheoCongThucNL.Checked = false;
            mnu_TheoCongThucMe.Checked = true;
            mnu_ChiTiet.Checked = false;
            cbo_tenNL.Enabled = false;
            cbo_SoHieuCt.Enabled = true;
            txt_MeSo.Enabled = true;
        }

        private void mnu_ChiTiet_Click(object sender, EventArgs e)
        {
            mnu_TheoNL.Checked = false;
            mnu_TheoCongThuc.Checked = false;
            mnu_TheoCongThucNL.Checked = false;
            mnu_TheoCongThucMe.Checked = false;
            mnu_ChiTiet.Checked = true;
            cbo_tenNL.Enabled = false;
            cbo_SoHieuCt.Enabled = true;
            txt_MeSo.Enabled = false;
        }
        #endregion LuaChonBaoCao

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            bool checkBaoCao = false;
            if(mnu_TheoNL.Checked == false&&mnu_TheoCongThuc.Checked == false&&mnu_TheoCongThucNL.Checked == false&&
                mnu_TheoCongThucMe.Checked == false&&mnu_ChiTiet.Checked == false)   //Nếu chưa chọn loại báo cáo
            {
                MessageBox.Show("Hãy chọn loại báo cáo");
                return;
            }    
            if (mnu_TheoNgay.Checked == false && mnu_TheoKhoangTg.Checked == false)  //Nếu chưa chọn thời gian báo cáo
            {
                MessageBox.Show("Hãy chọn thời gian báo cáo");
                return;
            }
            if(mnu_TheoKhoangTg.Checked == true)        //Nếu chọn theo khoảng thời gian
            {
                BeginTime = dtp_BeginDay.Value.Date + dtp_BeginTime.Value.TimeOfDay;
                EndTime = dtp_EndDay.Value.Date + dtp_EndTime.Value.TimeOfDay;
            }
            else
            {
                BeginTime = dtp_BeginDay.Value.Date;      
                EndTime = dtp_BeginDay.Value.Date.AddDays(1);        
            }

            #region TaoBangDuLieu
            ds.Tables.Clear();
            DataTable DuLieuCan = ds.Tables.Add("DuLieuCan");
            DuLieuCan.Columns.Add("Silo", Type.GetType("System.String"));
            DuLieuCan.Columns.Add("SoHieuCongThuc", Type.GetType("System.String"));
            DuLieuCan.Columns.Add("MeSo", Type.GetType("System.Int32"));
            DuLieuCan.Columns.Add("NguyenLieu", Type.GetType("System.String"));
            DuLieuCan.Columns.Add("KhoiLuongDat", Type.GetType("System.Single"));
            DuLieuCan.Columns.Add("KhoiLuongThuc", Type.GetType("System.Single"));
            DuLieuCan.Columns.Add("SaiLech", Type.GetType("System.Single"));
            DuLieuCan.Columns.Add("ThuTuCan", Type.GetType("System.String"));
            DuLieuCan.Columns.Add("Ngaydau", Type.GetType("System.DateTime"));
            DuLieuCan.Columns.Add("Ngaycuoi", Type.GetType("System.DateTime"));
            DuLieuCan.Columns.Add("NgayGhi", Type.GetType("System.String"));
            #endregion TaoBangDuLieu

            //Báo cáo theo tất cả hoặc 1 loại nguyên liệu đã cân cụ thể
            #region BaoCaoNguyenLieu
            if(mnu_TheoNL.Checked == true)
            {
                int SoNguyenLieu = cbo_tenNL.Items.Count;
                if (ketnoi.State == ConnectionState.Closed)
                    ketnoi.Open();
                //Nếu báo cáo tất cả nguyên liệu
                if (cbo_tenNL.Text == "[ALL]")
                {
                    //Load các dữ liệu cần thiết vào datatable
                    for (int i = 1; i < SoNguyenLieu; i++)
                    {
                        sql = @"Select * from Du_Lieu_Can Where NgayGhiInt >= N'" + QuyDoiThoiGian(BeginTime).ToString() + "'" +
                            "and NgayGhiInt <= N'" + QuyDoiThoiGian(EndTime).ToString() + "' and NguyenLieu = N'" + cbo_tenNL.Items[i].ToString() + "'";
                        thuchien = new SqlCommand(sql, ketnoi);
                        docdulieu = thuchien.ExecuteReader();
                        while (docdulieu.Read())
                        {
                            checkBaoCao = true;
                            row = DuLieuCan.NewRow();
                            row["Ngaydau"] = BeginTime;
                            row["Ngaycuoi"] = EndTime;
                            row["Silo"] = docdulieu["Silo"].ToString();
                            row["NguyenLieu"] = docdulieu["NguyenLieu"].ToString();
                            row["MeSo"] = int.Parse(docdulieu["MeSo"].ToString());
                            row["KhoiLuongDat"] = float.Parse(docdulieu["KhoiLuongDat"].ToString());
                            row["KhoiLuongThuc"] = float.Parse(docdulieu["KhoiLuongThuc"].ToString());
                            row["SaiLech"] = float.Parse(docdulieu["SaiLech"].ToString());
                            row["ThuTuCan"] = docdulieu["ThuTuCan"].ToString();
                            row["NgayGhi"] = docdulieu["NgayGhi"].ToString();

                            DuLieuCan.Rows.Add(row);
                        }
                        docdulieu.Close();
                    }
                    ketnoi.Close();
                }
                //Nếu báo cáo cho 1 nguyên liệu cụ thể
                else
                {
                    //Load các dữ liệu cần thiết vào datatable
                    sql = @"Select * from Du_Lieu_Can Where NgayGhiInt <= N'" + QuyDoiThoiGian(EndTime).ToString() + "' " +
                        "and NgayGhiInt >= N'" + QuyDoiThoiGian(BeginTime).ToString() + "' and NguyenLieu = N'" + cbo_tenNL.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    while (docdulieu.Read())
                    {
                        checkBaoCao = true;
                        row = DuLieuCan.NewRow();
                        row["Ngaydau"] = BeginTime;
                        row["Ngaycuoi"] = EndTime;
                        row["Silo"] = docdulieu["Silo"].ToString();
                        row["NguyenLieu"] = docdulieu["NguyenLieu"].ToString();
                        row["MeSo"] = int.Parse(docdulieu["MeSo"].ToString());
                        row["KhoiLuongDat"] = float.Parse(docdulieu["KhoiLuongDat"].ToString());
                        row["KhoiLuongThuc"] = float.Parse(docdulieu["KhoiLuongThuc"].ToString());
                        row["SaiLech"] = float.Parse(docdulieu["SaiLech"].ToString());
                        row["ThuTuCan"] = docdulieu["ThuTuCan"].ToString();
                        row["NgayGhi"] = docdulieu["NgayGhi"].ToString();

                        DuLieuCan.Rows.Add(row);
                    }
                    ketnoi.Close();
                }
                if (checkBaoCao == true)
                {
                    new frm_InBaoCao(ds, "SCADA.Report_NguyenLieu.rdlc").ShowDialog();
                }
                else
                    MessageBox.Show("Không có sản phẩm thỏa mãn tiêu chí báo cáo");

            }    

            #endregion BaoCaoNguyenLieu

            //Báo cáo theo tất cả hoặc 1 công thức đã cân cụ thể
            #region BaoCaoCongThuc      
            if (mnu_TheoCongThuc.Checked == true)
            {
                int SoCongThuc = cbo_SoHieuCt.Items.Count;
                if (ketnoi.State == ConnectionState.Closed)
                    ketnoi.Open();
                //Nếu báo cáo tất cả công thức
                if (cbo_SoHieuCt.Text == "[ALL]")
                {
                    //Load các dữ liệu cần thiết vào datatable
                    for (int i = 1; i < SoCongThuc; i++)
                    {
                        sql = @"Select * from Du_Lieu_Can Where NgayGhiInt >= N'"+QuyDoiThoiGian(BeginTime).ToString()+"'" +
                            "and NgayGhiInt <= N'"+QuyDoiThoiGian(EndTime).ToString()+"' and SoHieuCongThuc = N'"+cbo_SoHieuCt.Items[i].ToString()+"'";
                        thuchien = new SqlCommand(sql, ketnoi);
                        docdulieu = thuchien.ExecuteReader();
                        while (docdulieu.Read())
                        {
                            checkBaoCao = true;
                            row = DuLieuCan.NewRow();
                            row["Ngaydau"] = BeginTime;
                            row["Ngaycuoi"] = EndTime;
                            row["SoHieuCongThuc"] = docdulieu["SoHieuCongThuc"].ToString();
                            row["Silo"] = docdulieu["Silo"].ToString();
                            row["MeSo"] = int.Parse(docdulieu["MeSo"].ToString());
                            row["KhoiLuongDat"] = float.Parse(docdulieu["KhoiLuongDat"].ToString());
                            row["KhoiLuongThuc"] = float.Parse(docdulieu["KhoiLuongThuc"].ToString());
                            row["SaiLech"] = float.Parse(docdulieu["SaiLech"].ToString());
                            row["NgayGhi"] = docdulieu["NgayGhi"].ToString();

                            DuLieuCan.Rows.Add(row);
                        }
                        docdulieu.Close();
                    }
                    ketnoi.Close();
                }    
                //Nếu báo cáo cho 1 công thức cụ thể
                else
                {
                    //Load các dữ liệu cần thiết vào datatable
                    sql = @"Select * from Du_Lieu_Can Where NgayGhiInt <= N'" + QuyDoiThoiGian(EndTime).ToString() + "' " +
                        "and NgayGhiInt >= N'" + QuyDoiThoiGian(BeginTime).ToString() + "' and SoHieuCongThuc = N'" + cbo_SoHieuCt.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    while (docdulieu.Read())
                    {
                        checkBaoCao = true;
                        row = DuLieuCan.NewRow();
                        row["Ngaydau"] = BeginTime;
                        row["Ngaycuoi"] = EndTime;
                        row["SoHieuCongThuc"] = docdulieu["SoHieuCongThuc"].ToString();
                        row["Silo"] = docdulieu["Silo"].ToString();
                        row["MeSo"] = int.Parse(docdulieu["MeSo"].ToString());
                        row["KhoiLuongDat"] = float.Parse(docdulieu["KhoiLuongDat"].ToString());
                        row["KhoiLuongThuc"] = float.Parse(docdulieu["KhoiLuongThuc"].ToString());
                        row["SaiLech"] = float.Parse(docdulieu["SaiLech"].ToString());
                        row["NgayGhi"] = docdulieu["NgayGhi"].ToString();

                        DuLieuCan.Rows.Add(row);
                    }
                    ketnoi.Close();
                }
                if (checkBaoCao == true)
                {
                    new frm_InBaoCao(ds, "SCADA.Report_CongThuc.rdlc").ShowDialog();
                }
                else
                    MessageBox.Show("Không có sản phẩm thỏa mãn tiêu chí báo cáo");
            }
            #endregion BaoCaoCongThuc

            //Báo cáo theo công thức và nguyên liệu cụ thể đã cân
            #region BaoCaoCongThuc_NguyenLieu
            if (mnu_TheoCongThucNL.Checked == true)
            {
                if (cbo_SoHieuCt.Text == "[ALL]")
                    MessageBox.Show("Hãy chọn công thức");
                else if (cbo_tenNL.Text == "[ALL]")
                    MessageBox.Show("Hãy chọn tên nguyên liệu");
                else
                {
                    if (ketnoi.State == ConnectionState.Closed)
                        ketnoi.Open();
                    //Load các dữ liệu cần thiết vào datatable
                    sql = @"Select * from Du_Lieu_Can Where NgayGhiInt <= N'" + QuyDoiThoiGian(EndTime).ToString() + "' " +
                        "and NgayGhiInt >= N'" + QuyDoiThoiGian(BeginTime).ToString() + "' and SoHieuCongThuc = N'" + cbo_SoHieuCt.Text + "'" +
                        "and NguyenLieu = N'" + cbo_tenNL.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    while (docdulieu.Read())
                    {
                        checkBaoCao = true;
                        row = DuLieuCan.NewRow();
                        row["Ngaydau"] = BeginTime;
                        row["Ngaycuoi"] = EndTime;
                        row["SoHieuCongThuc"] = docdulieu["SoHieuCongThuc"].ToString();
                        row["NguyenLieu"] = docdulieu["NguyenLieu"].ToString();
                        row["KhoiLuongDat"] = float.Parse(docdulieu["KhoiLuongDat"].ToString());
                        row["KhoiLuongThuc"] = float.Parse(docdulieu["KhoiLuongThuc"].ToString());
                        row["SaiLech"] = float.Parse(docdulieu["SaiLech"].ToString());
                        row["NgayGhi"] = docdulieu["NgayGhi"].ToString();

                        DuLieuCan.Rows.Add(row);
                    }
                    ketnoi.Close();
                    if (checkBaoCao == true)
                    {
                        new frm_InBaoCao(ds, "SCADA.Report_CongThucNguyenLieu.rdlc").ShowDialog();
                    }
                    else
                        MessageBox.Show("Không có sản phẩm thỏa mãn tiêu chí báo cáo");
                }
            }
            #endregion BaoCaoCongThuc_NguyenLieu

            //Báo cáo theo công thức cụ thể và số thứ tự mẻ đã cân
            #region BaoCaoCongThuc_Me
            if(mnu_TheoCongThucMe.Checked == true)
            {
                if (cbo_SoHieuCt.Text == "[ALL]")
                    MessageBox.Show("Hãy chọn công thức");
                else if (txt_MeSo.Text == "")
                    MessageBox.Show("Hãy nhập số thứ tự mẻ");
                else
                {
                    if (ketnoi.State == ConnectionState.Closed)
                        ketnoi.Open();
                    //Load các dữ liệu cần thiết vào datatable
                    sql = @"Select * from Du_Lieu_Can Where NgayGhiInt <= N'" + QuyDoiThoiGian(EndTime).ToString() + "' " +
                        "and NgayGhiInt >= N'" + QuyDoiThoiGian(BeginTime).ToString() + "' and SoHieuCongThuc = N'" + cbo_SoHieuCt.Text + "'" +
                        "and MeSo = N'" + int.Parse(txt_MeSo.Text) + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    while (docdulieu.Read())
                    {
                        checkBaoCao = true;
                        row = DuLieuCan.NewRow();
                        row["Ngaydau"] = BeginTime;
                        row["Ngaycuoi"] = EndTime;
                        row["SoHieuCongThuc"] = docdulieu["SoHieuCongThuc"].ToString();
                        row["Silo"] = docdulieu["Silo"].ToString();
                        row["NguyenLieu"] = docdulieu["NguyenLieu"].ToString();
                        row["MeSo"] = int.Parse(txt_MeSo.Text);
                        row["KhoiLuongDat"] = float.Parse(docdulieu["KhoiLuongDat"].ToString());
                        row["KhoiLuongThuc"] = float.Parse(docdulieu["KhoiLuongThuc"].ToString());
                        row["SaiLech"] = float.Parse(docdulieu["SaiLech"].ToString());
                        row["ThuTuCan"] = docdulieu["ThuTuCan"].ToString();
                        row["NgayGhi"] = docdulieu["NgayGhi"].ToString();

                        DuLieuCan.Rows.Add(row);
                    }
                    ketnoi.Close();
                    if (checkBaoCao == true)
                    {
                        new frm_InBaoCao(ds, "SCADA.Report_CongThucMe.rdlc").ShowDialog();
                    }
                    else
                        MessageBox.Show("Không có sản phẩm thỏa mãn tiêu chí báo cáo");
                }
            }    
            #endregion BaoCaoCongThuc_Me

            //Báo cáo chi tiết các dữ liệu theo số hiệu công thức
            #region BaoCaoChiTiet
            if (mnu_ChiTiet.Checked == true)
            {
                if (cbo_SoHieuCt.Text == "[ALL]")
                    MessageBox.Show("Hãy lựa chọn công thức", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (ketnoi.State == ConnectionState.Closed)
                        ketnoi.Open();
                    //Load các dữ liệu cần thiết vào datatable
                    sql = @"Select * from Du_Lieu_Can Where NgayGhiInt <= N'"+QuyDoiThoiGian(EndTime).ToString()+"' " +
                        "and NgayGhiInt >= N'"+QuyDoiThoiGian(BeginTime).ToString()+ "' and SoHieuCongThuc = N'" + cbo_SoHieuCt.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    while(docdulieu.Read())
                    {
                        checkBaoCao = true;
                        row = DuLieuCan.NewRow();
                        row["Ngaydau"] = BeginTime;
                        row["Ngaycuoi"] = EndTime;
                        row["SoHieuCongThuc"] = docdulieu["SoHieuCongThuc"].ToString();
                        row["Silo"] = docdulieu["Silo"].ToString();
                        row["NguyenLieu"] = docdulieu["NguyenLieu"].ToString();
                        row["MeSo"] = int.Parse(docdulieu["MeSo"].ToString());
                        row["KhoiLuongDat"] = float.Parse(docdulieu["KhoiLuongDat"].ToString());
                        row["KhoiLuongThuc"] = float.Parse(docdulieu["KhoiLuongThuc"].ToString());
                        row["SaiLech"] = float.Parse(docdulieu["SaiLech"].ToString());
                        row["ThuTuCan"] = docdulieu["ThuTuCan"].ToString();
                        row["NgayGhi"] = docdulieu["NgayGhi"].ToString();

                        DuLieuCan.Rows.Add(row);
                    }
                    ketnoi.Close();
                    if (checkBaoCao == true)
                    {
                        new frm_InBaoCao(ds, "SCADA.Report_ChiTiet.rdlc").ShowDialog();
                    }
                    else
                        MessageBox.Show("Không có sản phẩm thỏa mãn tiêu chí báo cáo");
                }    
            }    
            #endregion BaoCaoChiTiet

        }

        private void txt_MeSo_KeyPress(object sender, KeyPressEventArgs e)  //Chỉ cho phép nhập số nguyên dương
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;       //Bỏ qua những cú pháp không hợp lệ
        }

        private void mnu_SaoLuuKhoiPhuc_Click(object sender, EventArgs e)
        {
            frm_SaoluuKhoiphuc frm = new frm_SaoluuKhoiphuc();
            frm.Show();
            this.Close();
        }

        private void mnu_ChonThuMuc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Hãy chọn thư mục chứa dữ liệu";
            fbd.ShowNewFolderButton = true; //Cho phép tạo thư mục mới
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;  //Thư mục khi mở lên là My Computer
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                mnu_ChonThuMuc.Text = fbd.SelectedPath;
            }
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            frm_Home frm = new frm_Home();
            frm.Show();
            this.Close();
        }
    }
}
