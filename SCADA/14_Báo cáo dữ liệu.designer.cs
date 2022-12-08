
namespace BTL
{
    partial class frm_Baocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LuaChonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TheoNL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TheoCongThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TheoCongThucNL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TheoCongThucMe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoiGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TheoNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TheoKhoangTg = new System.Windows.Forms.ToolStripMenuItem();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SaoLuuKhoiPhuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThuMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ChonThuMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_tenNL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_SoHieuCt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MeSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_NgayDau = new System.Windows.Forms.Label();
            this.lbl_GioDau = new System.Windows.Forms.Label();
            this.lbl_GioCuoi = new System.Windows.Forms.Label();
            this.lbl_NgayCuoi = new System.Windows.Forms.Label();
            this.lbl_Den = new System.Windows.Forms.Label();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.btn_QuayVe = new System.Windows.Forms.Button();
            this.dtp_BeginDay = new System.Windows.Forms.DateTimePicker();
            this.dtp_BeginTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDay = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LuaChonToolStripMenuItem,
            this.ThoiGianToolStripMenuItem,
            this.HeThongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LuaChonToolStripMenuItem
            // 
            this.LuaChonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_TheoNL,
            this.mnu_TheoCongThuc,
            this.mnu_TheoCongThucNL,
            this.mnu_TheoCongThucMe,
            this.mnu_ChiTiet});
            this.LuaChonToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuaChonToolStripMenuItem.Name = "LuaChonToolStripMenuItem";
            this.LuaChonToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.LuaChonToolStripMenuItem.Text = "Lựa chọn";
            // 
            // mnu_TheoNL
            // 
            this.mnu_TheoNL.Name = "mnu_TheoNL";
            this.mnu_TheoNL.Size = new System.Drawing.Size(492, 28);
            this.mnu_TheoNL.Text = "Theo Tên nguyên liệu                                  Ctrl+M";
            this.mnu_TheoNL.Click += new System.EventHandler(this.Mnu_TheoNL_Click);
            // 
            // mnu_TheoCongThuc
            // 
            this.mnu_TheoCongThuc.Name = "mnu_TheoCongThuc";
            this.mnu_TheoCongThuc.Size = new System.Drawing.Size(492, 28);
            this.mnu_TheoCongThuc.Text = "Theo Công thức                            Ctrl+L";
            this.mnu_TheoCongThuc.Click += new System.EventHandler(this.mnu_TheoCongThuc_Click);
            // 
            // mnu_TheoCongThucNL
            // 
            this.mnu_TheoCongThucNL.Name = "mnu_TheoCongThucNL";
            this.mnu_TheoCongThucNL.Size = new System.Drawing.Size(492, 28);
            this.mnu_TheoCongThucNL.Text = "Theo Công thức và Tên NL          Ctrl+F";
            this.mnu_TheoCongThucNL.Click += new System.EventHandler(this.mnu_TheoCongThucNL_Click);
            // 
            // mnu_TheoCongThucMe
            // 
            this.mnu_TheoCongThucMe.Name = "mnu_TheoCongThucMe";
            this.mnu_TheoCongThucMe.Size = new System.Drawing.Size(492, 28);
            this.mnu_TheoCongThucMe.Text = "Theo Công thức và số mẻ trộn     Ctrl+K";
            this.mnu_TheoCongThucMe.Click += new System.EventHandler(this.mnu_TheoCongThucMe_Click);
            // 
            // mnu_ChiTiet
            // 
            this.mnu_ChiTiet.Name = "mnu_ChiTiet";
            this.mnu_ChiTiet.Size = new System.Drawing.Size(492, 28);
            this.mnu_ChiTiet.Text = "Báo cáo chi tiết";
            this.mnu_ChiTiet.Click += new System.EventHandler(this.mnu_ChiTiet_Click);
            // 
            // ThoiGianToolStripMenuItem
            // 
            this.ThoiGianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_TheoNgay,
            this.mnu_TheoKhoangTg});
            this.ThoiGianToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoiGianToolStripMenuItem.Name = "ThoiGianToolStripMenuItem";
            this.ThoiGianToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.ThoiGianToolStripMenuItem.Text = "Thời gian";
            // 
            // mnu_TheoNgay
            // 
            this.mnu_TheoNgay.Name = "mnu_TheoNgay";
            this.mnu_TheoNgay.Size = new System.Drawing.Size(223, 28);
            this.mnu_TheoNgay.Text = "Theo ngày";
            this.mnu_TheoNgay.Click += new System.EventHandler(this.mnu_TheoNgay_Click);
            // 
            // mnu_TheoKhoangTg
            // 
            this.mnu_TheoKhoangTg.Name = "mnu_TheoKhoangTg";
            this.mnu_TheoKhoangTg.Size = new System.Drawing.Size(223, 28);
            this.mnu_TheoKhoangTg.Text = "Khoảng thời gian";
            this.mnu_TheoKhoangTg.Click += new System.EventHandler(this.mnu_TheoKhoangTg_Click);
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_SaoLuuKhoiPhuc,
            this.mnu_ThuMuc});
            this.HeThongToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.HeThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnu_SaoLuuKhoiPhuc
            // 
            this.mnu_SaoLuuKhoiPhuc.Name = "mnu_SaoLuuKhoiPhuc";
            this.mnu_SaoLuuKhoiPhuc.Size = new System.Drawing.Size(256, 28);
            this.mnu_SaoLuuKhoiPhuc.Text = "Sao lưu và khôi phục";
            this.mnu_SaoLuuKhoiPhuc.Click += new System.EventHandler(this.mnu_SaoLuuKhoiPhuc_Click);
            // 
            // mnu_ThuMuc
            // 
            this.mnu_ThuMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ChonThuMuc});
            this.mnu_ThuMuc.Name = "mnu_ThuMuc";
            this.mnu_ThuMuc.Size = new System.Drawing.Size(256, 28);
            this.mnu_ThuMuc.Text = "Thư mục file báo cáo";
            // 
            // mnu_ChonThuMuc
            // 
            this.mnu_ChonThuMuc.Name = "mnu_ChonThuMuc";
            this.mnu_ChonThuMuc.Size = new System.Drawing.Size(376, 28);
            this.mnu_ChonThuMuc.Text = "Lựa chọn thư mục chứa file báo cáo";
            this.mnu_ChonThuMuc.Click += new System.EventHandler(this.mnu_ChonThuMuc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(86, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "HÃY LỰA CHỌN THÔNG SỐ BÁO CÁO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Nguyên liệu :";
            // 
            // cbo_tenNL
            // 
            this.cbo_tenNL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tenNL.FormattingEnabled = true;
            this.cbo_tenNL.Location = new System.Drawing.Point(332, 96);
            this.cbo_tenNL.Name = "cbo_tenNL";
            this.cbo_tenNL.Size = new System.Drawing.Size(156, 29);
            this.cbo_tenNL.TabIndex = 7;
            this.cbo_tenNL.Text = "[ALL]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số hiệu Công thức :";
            // 
            // cbo_SoHieuCt
            // 
            this.cbo_SoHieuCt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_SoHieuCt.FormattingEnabled = true;
            this.cbo_SoHieuCt.Location = new System.Drawing.Point(332, 136);
            this.cbo_SoHieuCt.Name = "cbo_SoHieuCt";
            this.cbo_SoHieuCt.Size = new System.Drawing.Size(156, 29);
            this.cbo_SoHieuCt.TabIndex = 9;
            this.cbo_SoHieuCt.Text = "[ALL]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mẻ số :";
            // 
            // txt_MeSo
            // 
            this.txt_MeSo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MeSo.Location = new System.Drawing.Point(332, 179);
            this.txt_MeSo.Multiline = true;
            this.txt_MeSo.Name = "txt_MeSo";
            this.txt_MeSo.Size = new System.Drawing.Size(156, 25);
            this.txt_MeSo.TabIndex = 11;
            this.txt_MeSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MeSo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thời gian :";
            // 
            // lbl_NgayDau
            // 
            this.lbl_NgayDau.AutoSize = true;
            this.lbl_NgayDau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayDau.Location = new System.Drawing.Point(48, 282);
            this.lbl_NgayDau.Name = "lbl_NgayDau";
            this.lbl_NgayDau.Size = new System.Drawing.Size(64, 23);
            this.lbl_NgayDau.TabIndex = 13;
            this.lbl_NgayDau.Text = "Ngày :";
            // 
            // lbl_GioDau
            // 
            this.lbl_GioDau.AutoSize = true;
            this.lbl_GioDau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioDau.Location = new System.Drawing.Point(48, 322);
            this.lbl_GioDau.Name = "lbl_GioDau";
            this.lbl_GioDau.Size = new System.Drawing.Size(53, 23);
            this.lbl_GioDau.TabIndex = 15;
            this.lbl_GioDau.Text = "Giờ :";
            // 
            // lbl_GioCuoi
            // 
            this.lbl_GioCuoi.AutoSize = true;
            this.lbl_GioCuoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioCuoi.Location = new System.Drawing.Point(344, 322);
            this.lbl_GioCuoi.Name = "lbl_GioCuoi";
            this.lbl_GioCuoi.Size = new System.Drawing.Size(53, 23);
            this.lbl_GioCuoi.TabIndex = 17;
            this.lbl_GioCuoi.Text = "Giờ :";
            // 
            // lbl_NgayCuoi
            // 
            this.lbl_NgayCuoi.AutoSize = true;
            this.lbl_NgayCuoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayCuoi.Location = new System.Drawing.Point(344, 282);
            this.lbl_NgayCuoi.Name = "lbl_NgayCuoi";
            this.lbl_NgayCuoi.Size = new System.Drawing.Size(64, 23);
            this.lbl_NgayCuoi.TabIndex = 16;
            this.lbl_NgayCuoi.Text = "Ngày :";
            // 
            // lbl_Den
            // 
            this.lbl_Den.AutoSize = true;
            this.lbl_Den.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Den.Location = new System.Drawing.Point(275, 299);
            this.lbl_Den.Name = "lbl_Den";
            this.lbl_Den.Size = new System.Drawing.Size(49, 23);
            this.lbl_Den.TabIndex = 18;
            this.lbl_Den.Text = "Đến ";
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.Location = new System.Drawing.Point(135, 398);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(102, 50);
            this.btn_HienThi.TabIndex = 19;
            this.btn_HienThi.Text = "Hiển thị";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // btn_QuayVe
            // 
            this.btn_QuayVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_QuayVe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayVe.Location = new System.Drawing.Point(368, 398);
            this.btn_QuayVe.Name = "btn_QuayVe";
            this.btn_QuayVe.Size = new System.Drawing.Size(102, 50);
            this.btn_QuayVe.TabIndex = 20;
            this.btn_QuayVe.Text = "Quay về";
            this.btn_QuayVe.UseVisualStyleBackColor = true;
            this.btn_QuayVe.Click += new System.EventHandler(this.btn_QuayVe_Click);
            // 
            // dtp_BeginDay
            // 
            this.dtp_BeginDay.CustomFormat = "dd/MM/yyyy";
            this.dtp_BeginDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_BeginDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_BeginDay.Location = new System.Drawing.Point(126, 278);
            this.dtp_BeginDay.Name = "dtp_BeginDay";
            this.dtp_BeginDay.Size = new System.Drawing.Size(111, 27);
            this.dtp_BeginDay.TabIndex = 40;
            // 
            // dtp_BeginTime
            // 
            this.dtp_BeginTime.CustomFormat = "hh:mm:ss";
            this.dtp_BeginTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_BeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_BeginTime.Location = new System.Drawing.Point(126, 319);
            this.dtp_BeginTime.Name = "dtp_BeginTime";
            this.dtp_BeginTime.ShowUpDown = true;
            this.dtp_BeginTime.Size = new System.Drawing.Size(111, 27);
            this.dtp_BeginTime.TabIndex = 41;
            // 
            // dtp_EndTime
            // 
            this.dtp_EndTime.CustomFormat = "hh:mm:ss";
            this.dtp_EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_EndTime.Location = new System.Drawing.Point(423, 318);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.ShowUpDown = true;
            this.dtp_EndTime.Size = new System.Drawing.Size(111, 27);
            this.dtp_EndTime.TabIndex = 43;
            // 
            // dtp_EndDay
            // 
            this.dtp_EndDay.CustomFormat = "dd/MM/yyyy";
            this.dtp_EndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDay.Location = new System.Drawing.Point(423, 277);
            this.dtp_EndDay.Name = "dtp_EndDay";
            this.dtp_EndDay.Size = new System.Drawing.Size(111, 27);
            this.dtp_EndDay.TabIndex = 42;
            // 
            // frm_Baocao
            // 
            this.AcceptButton = this.btn_HienThi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.btn_QuayVe;
            this.ClientSize = new System.Drawing.Size(609, 481);
            this.Controls.Add(this.dtp_EndTime);
            this.Controls.Add(this.dtp_EndDay);
            this.Controls.Add(this.dtp_BeginTime);
            this.Controls.Add(this.dtp_BeginDay);
            this.Controls.Add(this.btn_QuayVe);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.lbl_Den);
            this.Controls.Add(this.lbl_GioCuoi);
            this.Controls.Add(this.lbl_NgayCuoi);
            this.Controls.Add(this.lbl_GioDau);
            this.Controls.Add(this.lbl_NgayDau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MeSo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_SoHieuCt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_tenNL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_Baocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frm_Baocao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LuaChonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_TheoNL;
        private System.Windows.Forms.ToolStripMenuItem mnu_TheoCongThuc;
        private System.Windows.Forms.ToolStripMenuItem ThoiGianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_TheoCongThucNL;
        private System.Windows.Forms.ToolStripMenuItem mnu_TheoCongThucMe;
        private System.Windows.Forms.ToolStripMenuItem mnu_TheoNgay;
        private System.Windows.Forms.ToolStripMenuItem mnu_TheoKhoangTg;
        private System.Windows.Forms.ToolStripMenuItem mnu_SaoLuuKhoiPhuc;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThuMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_tenNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_SoHieuCt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MeSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_NgayDau;
        private System.Windows.Forms.Label lbl_GioDau;
        private System.Windows.Forms.Label lbl_GioCuoi;
        private System.Windows.Forms.Label lbl_NgayCuoi;
        private System.Windows.Forms.Label lbl_Den;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.DateTimePicker dtp_BeginDay;
        private System.Windows.Forms.DateTimePicker dtp_BeginTime;
        private System.Windows.Forms.DateTimePicker dtp_EndTime;
        private System.Windows.Forms.DateTimePicker dtp_EndDay;
        private System.Windows.Forms.ToolStripMenuItem mnu_ChiTiet;
        private System.Windows.Forms.ToolStripMenuItem mnu_ChonThuMuc;
    }
}