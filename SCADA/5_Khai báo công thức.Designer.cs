
namespace SCADA
{
    partial class frm_KhaiBaoCt
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_QuayVe = new System.Windows.Forms.Button();
            this.lsv_CongThuc = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CongThuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoHieuCt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbn_ThemCt = new System.Windows.Forms.RadioButton();
            this.rbn_SuaCt = new System.Windows.Forms.RadioButton();
            this.rbn_XoaCt = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(299, 78);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(102, 56);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_QuayVe
            // 
            this.btn_QuayVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_QuayVe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayVe.Location = new System.Drawing.Point(299, 156);
            this.btn_QuayVe.Name = "btn_QuayVe";
            this.btn_QuayVe.Size = new System.Drawing.Size(102, 56);
            this.btn_QuayVe.TabIndex = 7;
            this.btn_QuayVe.Text = "Quay về";
            this.btn_QuayVe.UseVisualStyleBackColor = true;
            this.btn_QuayVe.Click += new System.EventHandler(this.btn_QuayVe_Click);
            // 
            // lsv_CongThuc
            // 
            this.lsv_CongThuc.BackColor = System.Drawing.Color.SkyBlue;
            this.lsv_CongThuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lsv_CongThuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_CongThuc.FullRowSelect = true;
            this.lsv_CongThuc.GridLines = true;
            this.lsv_CongThuc.HideSelection = false;
            this.lsv_CongThuc.Location = new System.Drawing.Point(434, 23);
            this.lsv_CongThuc.Name = "lsv_CongThuc";
            this.lsv_CongThuc.Size = new System.Drawing.Size(326, 477);
            this.lsv_CongThuc.TabIndex = 12;
            this.lsv_CongThuc.UseCompatibleStateImageBehavior = false;
            this.lsv_CongThuc.View = System.Windows.Forms.View.Details;
            this.lsv_CongThuc.Click += new System.EventHandler(this.lsv_CongThuc_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên công thức";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số hiệu";
            this.columnHeader3.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên công thức :";
            // 
            // txt_CongThuc
            // 
            this.txt_CongThuc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CongThuc.Location = new System.Drawing.Point(182, 13);
            this.txt_CongThuc.Multiline = true;
            this.txt_CongThuc.Name = "txt_CongThuc";
            this.txt_CongThuc.Size = new System.Drawing.Size(204, 35);
            this.txt_CongThuc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số hiệu công thức :";
            // 
            // txt_SoHieuCt
            // 
            this.txt_SoHieuCt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoHieuCt.Location = new System.Drawing.Point(182, 61);
            this.txt_SoHieuCt.Multiline = true;
            this.txt_SoHieuCt.Name = "txt_SoHieuCt";
            this.txt_SoHieuCt.Size = new System.Drawing.Size(204, 35);
            this.txt_SoHieuCt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(68, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "LỰA CHỌN CÔNG THỨC";
            // 
            // rbn_ThemCt
            // 
            this.rbn_ThemCt.AutoSize = true;
            this.rbn_ThemCt.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.rbn_ThemCt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbn_ThemCt.Location = new System.Drawing.Point(13, 10);
            this.rbn_ThemCt.Name = "rbn_ThemCt";
            this.rbn_ThemCt.Size = new System.Drawing.Size(186, 31);
            this.rbn_ThemCt.TabIndex = 2;
            this.rbn_ThemCt.TabStop = true;
            this.rbn_ThemCt.Text = "Thêm công thức";
            this.rbn_ThemCt.UseVisualStyleBackColor = true;
            // 
            // rbn_SuaCt
            // 
            this.rbn_SuaCt.AutoSize = true;
            this.rbn_SuaCt.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.rbn_SuaCt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbn_SuaCt.Location = new System.Drawing.Point(13, 60);
            this.rbn_SuaCt.Name = "rbn_SuaCt";
            this.rbn_SuaCt.Size = new System.Drawing.Size(167, 31);
            this.rbn_SuaCt.TabIndex = 3;
            this.rbn_SuaCt.TabStop = true;
            this.rbn_SuaCt.Text = "Sửa công thức";
            this.rbn_SuaCt.UseVisualStyleBackColor = true;
            // 
            // rbn_XoaCt
            // 
            this.rbn_XoaCt.AutoSize = true;
            this.rbn_XoaCt.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.rbn_XoaCt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbn_XoaCt.Location = new System.Drawing.Point(13, 107);
            this.rbn_XoaCt.Name = "rbn_XoaCt";
            this.rbn_XoaCt.Size = new System.Drawing.Size(171, 31);
            this.rbn_XoaCt.TabIndex = 4;
            this.rbn_XoaCt.TabStop = true;
            this.rbn_XoaCt.Text = "Xóa công thức";
            this.rbn_XoaCt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbn_XoaCt);
            this.panel1.Controls.Add(this.rbn_SuaCt);
            this.panel1.Controls.Add(this.rbn_ThemCt);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 157);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_SoHieuCt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_CongThuc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 115);
            this.panel2.TabIndex = 13;
            // 
            // frm_KhaiBaoCt
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.btn_QuayVe;
            this.ClientSize = new System.Drawing.Size(779, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lsv_CongThuc);
            this.Controls.Add(this.btn_QuayVe);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_KhaiBaoCt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khai_Bao_Cong_Thuc";
            this.Load += new System.EventHandler(this.frm_KhaiBaoCt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.ListView lsv_CongThuc;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CongThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoHieuCt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbn_ThemCt;
        private System.Windows.Forms.RadioButton rbn_SuaCt;
        private System.Windows.Forms.RadioButton rbn_XoaCt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}