
namespace SCADA
{
    partial class frm_CaiDatTong
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
            this.txt_TongSoMt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_KLThem = new System.Windows.Forms.TextBox();
            this.txt_KLMe = new System.Windows.Forms.TextBox();
            this.cbo_SoHieuCt = new System.Windows.Forms.ComboBox();
            this.btn_QuayVe = new System.Windows.Forms.Button();
            this.txt_ThoiGianXa = new System.Windows.Forms.TextBox();
            this.txt_ThoiGianTron = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(111, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÀI ĐẶT TỔNG QUÁT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số hiệu công thức:";
            // 
            // txt_TongSoMt
            // 
            this.txt_TongSoMt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongSoMt.Location = new System.Drawing.Point(265, 109);
            this.txt_TongSoMt.Margin = new System.Windows.Forms.Padding(5);
            this.txt_TongSoMt.Multiline = true;
            this.txt_TongSoMt.Name = "txt_TongSoMt";
            this.txt_TongSoMt.Size = new System.Drawing.Size(157, 29);
            this.txt_TongSoMt.TabIndex = 1;
            this.txt_TongSoMt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TongSoMt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TongSoMt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số mẻ trộn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thời gian trộn (s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thời gian xả trộn (s):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Khối lượng thêm tay (kg):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 332);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Khối lượng mẻ (kg):";
            // 
            // btn_Luu
            // 
            this.btn_Luu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btn_Luu.Location = new System.Drawing.Point(110, 388);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 49);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_KLThem
            // 
            this.txt_KLThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KLThem.Location = new System.Drawing.Point(265, 270);
            this.txt_KLThem.Margin = new System.Windows.Forms.Padding(5);
            this.txt_KLThem.Multiline = true;
            this.txt_KLThem.Name = "txt_KLThem";
            this.txt_KLThem.ReadOnly = true;
            this.txt_KLThem.Size = new System.Drawing.Size(157, 29);
            this.txt_KLThem.TabIndex = 4;
            this.txt_KLThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_KLMe
            // 
            this.txt_KLMe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KLMe.Location = new System.Drawing.Point(265, 326);
            this.txt_KLMe.Margin = new System.Windows.Forms.Padding(5);
            this.txt_KLMe.Multiline = true;
            this.txt_KLMe.Name = "txt_KLMe";
            this.txt_KLMe.ReadOnly = true;
            this.txt_KLMe.Size = new System.Drawing.Size(157, 29);
            this.txt_KLMe.TabIndex = 5;
            this.txt_KLMe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_SoHieuCt
            // 
            this.cbo_SoHieuCt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SoHieuCt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_SoHieuCt.Location = new System.Drawing.Point(264, 62);
            this.cbo_SoHieuCt.Name = "cbo_SoHieuCt";
            this.cbo_SoHieuCt.Size = new System.Drawing.Size(158, 29);
            this.cbo_SoHieuCt.TabIndex = 0;
            this.cbo_SoHieuCt.SelectedValueChanged += new System.EventHandler(this.cbo_SoHieuCt_SelectedValueChanged);
            // 
            // btn_QuayVe
            // 
            this.btn_QuayVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_QuayVe.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btn_QuayVe.Location = new System.Drawing.Point(254, 388);
            this.btn_QuayVe.Name = "btn_QuayVe";
            this.btn_QuayVe.Size = new System.Drawing.Size(100, 49);
            this.btn_QuayVe.TabIndex = 7;
            this.btn_QuayVe.Text = "Quay về";
            this.btn_QuayVe.UseVisualStyleBackColor = true;
            this.btn_QuayVe.Click += new System.EventHandler(this.btn_QuayVe_Click);
            // 
            // txt_ThoiGianXa
            // 
            this.txt_ThoiGianXa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiGianXa.Location = new System.Drawing.Point(265, 214);
            this.txt_ThoiGianXa.Margin = new System.Windows.Forms.Padding(5);
            this.txt_ThoiGianXa.Multiline = true;
            this.txt_ThoiGianXa.Name = "txt_ThoiGianXa";
            this.txt_ThoiGianXa.Size = new System.Drawing.Size(157, 29);
            this.txt_ThoiGianXa.TabIndex = 3;
            this.txt_ThoiGianXa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ThoiGianXa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ThoiGianXa_KeyPress);
            // 
            // txt_ThoiGianTron
            // 
            this.txt_ThoiGianTron.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiGianTron.Location = new System.Drawing.Point(265, 160);
            this.txt_ThoiGianTron.Margin = new System.Windows.Forms.Padding(5);
            this.txt_ThoiGianTron.Multiline = true;
            this.txt_ThoiGianTron.Name = "txt_ThoiGianTron";
            this.txt_ThoiGianTron.Size = new System.Drawing.Size(157, 29);
            this.txt_ThoiGianTron.TabIndex = 2;
            this.txt_ThoiGianTron.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ThoiGianTron.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ThoiGianTron_KeyPress);
            // 
            // frm_CaiDatTong
            // 
            this.AcceptButton = this.btn_Luu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.btn_QuayVe;
            this.ClientSize = new System.Drawing.Size(471, 459);
            this.Controls.Add(this.btn_QuayVe);
            this.Controls.Add(this.cbo_SoHieuCt);
            this.Controls.Add(this.txt_KLMe);
            this.Controls.Add(this.txt_KLThem);
            this.Controls.Add(this.txt_ThoiGianXa);
            this.Controls.Add(this.txt_ThoiGianTron);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TongSoMt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frm_CaiDatTong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt tổng quát";
            this.Load += new System.EventHandler(this.frm_CaiDatTong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TongSoMt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_KLThem;
        private System.Windows.Forms.TextBox txt_KLMe;
        private System.Windows.Forms.ComboBox cbo_SoHieuCt;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.TextBox txt_ThoiGianXa;
        private System.Windows.Forms.TextBox txt_ThoiGianTron;
    }
}