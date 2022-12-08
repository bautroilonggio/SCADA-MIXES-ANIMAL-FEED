
namespace SCADA
{
    partial class frm_DangNhap
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
            this.components = new System.ComponentModel.Container();
            this.DemNguoc = new System.Windows.Forms.Timer(this.components);
            this.pb_HienMatKhau = new System.Windows.Forms.PictureBox();
            this.lbl_s = new System.Windows.Forms.Label();
            this.lbl_Giay = new System.Windows.Forms.Label();
            this.lbl_ThongBaoDN = new System.Windows.Forms.Label();
            this.pb_AnMatKhau = new System.Windows.Forms.PictureBox();
            this.btn_DoiMatKhau = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HienMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DemNguoc
            // 
            this.DemNguoc.Interval = 1000;
            this.DemNguoc.Tick += new System.EventHandler(this.DemNguoc_Tick);
            // 
            // pb_HienMatKhau
            // 
            this.pb_HienMatKhau.BackColor = System.Drawing.Color.White;
            this.pb_HienMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_HienMatKhau.Image = global::SCADA.Properties.Resources.show;
            this.pb_HienMatKhau.Location = new System.Drawing.Point(674, 175);
            this.pb_HienMatKhau.Name = "pb_HienMatKhau";
            this.pb_HienMatKhau.Size = new System.Drawing.Size(30, 32);
            this.pb_HienMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_HienMatKhau.TabIndex = 29;
            this.pb_HienMatKhau.TabStop = false;
            this.pb_HienMatKhau.Click += new System.EventHandler(this.pb_HienMatKhau_Click);
            // 
            // lbl_s
            // 
            this.lbl_s.AutoSize = true;
            this.lbl_s.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_s.Location = new System.Drawing.Point(614, 216);
            this.lbl_s.Name = "lbl_s";
            this.lbl_s.Size = new System.Drawing.Size(35, 16);
            this.lbl_s.TabIndex = 28;
            this.lbl_s.Text = "(s)...";
            // 
            // lbl_Giay
            // 
            this.lbl_Giay.AutoSize = true;
            this.lbl_Giay.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Giay.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Giay.Location = new System.Drawing.Point(597, 216);
            this.lbl_Giay.Name = "lbl_Giay";
            this.lbl_Giay.Size = new System.Drawing.Size(22, 16);
            this.lbl_Giay.TabIndex = 27;
            this.lbl_Giay.Text = "30";
            // 
            // lbl_ThongBaoDN
            // 
            this.lbl_ThongBaoDN.AutoSize = true;
            this.lbl_ThongBaoDN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBaoDN.Location = new System.Drawing.Point(489, 216);
            this.lbl_ThongBaoDN.Name = "lbl_ThongBaoDN";
            this.lbl_ThongBaoDN.Size = new System.Drawing.Size(117, 16);
            this.lbl_ThongBaoDN.TabIndex = 26;
            this.lbl_ThongBaoDN.Text = "Đăng nhập lại sau ";
            // 
            // pb_AnMatKhau
            // 
            this.pb_AnMatKhau.BackColor = System.Drawing.Color.White;
            this.pb_AnMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_AnMatKhau.Image = global::SCADA.Properties.Resources.hide3;
            this.pb_AnMatKhau.Location = new System.Drawing.Point(674, 175);
            this.pb_AnMatKhau.Name = "pb_AnMatKhau";
            this.pb_AnMatKhau.Size = new System.Drawing.Size(30, 32);
            this.pb_AnMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AnMatKhau.TabIndex = 25;
            this.pb_AnMatKhau.TabStop = false;
            this.pb_AnMatKhau.Click += new System.EventHandler(this.pb_AnMatKhau_Click);
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_DoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(420, 293);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(142, 45);
            this.btn_DoiMatKhau.TabIndex = 23;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu";
            this.btn_DoiMatKhau.UseVisualStyleBackColor = true;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Thoat.Location = new System.Drawing.Point(562, 293);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(142, 45);
            this.btn_Thoat.TabIndex = 24;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.AccessibleDescription = "";
            this.btn_DangNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_DangNhap.Location = new System.Drawing.Point(420, 237);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(284, 50);
            this.btn_DangNhap.TabIndex = 22;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::SCADA.Properties.Resources.login_icon;
            this.pictureBox2.Location = new System.Drawing.Point(420, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(451, 175);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(253, 32);
            this.txt_MatKhau.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SCADA.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(420, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(451, 127);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(253, 32);
            this.txt_TaiKhoan.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(487, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // frm_DangNhap
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCADA.Properties.Resources.background_login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.pb_HienMatKhau);
            this.Controls.Add(this.lbl_s);
            this.Controls.Add(this.lbl_Giay);
            this.Controls.Add(this.lbl_ThongBaoDN);
            this.Controls.Add(this.pb_AnMatKhau);
            this.Controls.Add(this.btn_DoiMatKhau);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_HienMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer DemNguoc;
        private System.Windows.Forms.PictureBox pb_HienMatKhau;
        private System.Windows.Forms.Label lbl_s;
        private System.Windows.Forms.Label lbl_Giay;
        private System.Windows.Forms.Label lbl_ThongBaoDN;
        private System.Windows.Forms.PictureBox pb_AnMatKhau;
        private System.Windows.Forms.Button btn_DoiMatKhau;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label1;
    }
}