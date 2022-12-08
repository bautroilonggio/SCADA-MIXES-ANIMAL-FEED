
namespace BTL
{
    partial class frm_SaoluuKhoiphuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ChonThuMuc = new System.Windows.Forms.Button();
            this.txt_ThuMuc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsv_file = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_SaoLuu = new System.Windows.Forms.Button();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.btn_QuayVe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(271, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAO LƯU VÀ KHÔI PHỤC DỮ LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btn_ChonThuMuc
            // 
            this.btn_ChonThuMuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonThuMuc.Location = new System.Drawing.Point(55, 45);
            this.btn_ChonThuMuc.Name = "btn_ChonThuMuc";
            this.btn_ChonThuMuc.Size = new System.Drawing.Size(126, 34);
            this.btn_ChonThuMuc.TabIndex = 2;
            this.btn_ChonThuMuc.Text = "Chọn thư mục";
            this.btn_ChonThuMuc.UseVisualStyleBackColor = true;
            this.btn_ChonThuMuc.Click += new System.EventHandler(this.btn_ChonThuMuc_Click);
            // 
            // txt_ThuMuc
            // 
            this.txt_ThuMuc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThuMuc.Location = new System.Drawing.Point(187, 46);
            this.txt_ThuMuc.Multiline = true;
            this.txt_ThuMuc.Name = "txt_ThuMuc";
            this.txt_ThuMuc.Size = new System.Drawing.Size(599, 31);
            this.txt_ThuMuc.TabIndex = 3;
            this.txt_ThuMuc.Text = "D:\\Phanmem\\SCADA\\SCADA_v3\\SaoLuu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsv_file);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 379);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dữ liệu";
            // 
            // lsv_file
            // 
            this.lsv_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lsv_file.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4});
            this.lsv_file.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_file.FullRowSelect = true;
            this.lsv_file.GridLines = true;
            this.lsv_file.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsv_file.HideSelection = false;
            this.lsv_file.Location = new System.Drawing.Point(9, 24);
            this.lsv_file.Name = "lsv_file";
            this.lsv_file.Size = new System.Drawing.Size(715, 349);
            this.lsv_file.TabIndex = 0;
            this.lsv_file.UseCompatibleStateImageBehavior = false;
            this.lsv_file.View = System.Windows.Forms.View.Details;
            this.lsv_file.Click += new System.EventHandler(this.lsv_file_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày sao lưu";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "                                                            Đường dẫn file";
            this.columnHeader4.Width = 605;
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaoLuu.Location = new System.Drawing.Point(217, 499);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(113, 43);
            this.btn_SaoLuu.TabIndex = 5;
            this.btn_SaoLuu.Text = "Sao lưu";
            this.btn_SaoLuu.UseVisualStyleBackColor = true;
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(380, 499);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(113, 43);
            this.btn_KhoiPhuc.TabIndex = 6;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = true;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // btn_QuayVe
            // 
            this.btn_QuayVe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayVe.Location = new System.Drawing.Point(541, 499);
            this.btn_QuayVe.Name = "btn_QuayVe";
            this.btn_QuayVe.Size = new System.Drawing.Size(113, 43);
            this.btn_QuayVe.TabIndex = 7;
            this.btn_QuayVe.Text = "Quay về";
            this.btn_QuayVe.UseVisualStyleBackColor = true;
            this.btn_QuayVe.Click += new System.EventHandler(this.btn_QuayVe_Click);
            // 
            // frm_SaoluuKhoiphuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(846, 563);
            this.Controls.Add(this.btn_QuayVe);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.btn_SaoLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_ThuMuc);
            this.Controls.Add(this.btn_ChonThuMuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frm_SaoluuKhoiphuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu và khôi phục";
            this.Load += new System.EventHandler(this.frm_SaoluuKhoiphuc_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ChonThuMuc;
        private System.Windows.Forms.TextBox txt_ThuMuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsv_file;
        private System.Windows.Forms.Button btn_SaoLuu;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}