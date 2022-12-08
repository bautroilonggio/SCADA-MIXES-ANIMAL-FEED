
namespace BTL
{
    partial class frm_CaiDatFine
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_QuanTinh = new System.Windows.Forms.TextBox();
            this.cbo_Silo = new System.Windows.Forms.ComboBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(119, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÀI ĐẶT QUÁN TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(65, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lựa chọn silo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(65, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quán Tính (kg) :";
            // 
            // txt_QuanTinh
            // 
            this.txt_QuanTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuanTinh.Location = new System.Drawing.Point(250, 145);
            this.txt_QuanTinh.Multiline = true;
            this.txt_QuanTinh.Name = "txt_QuanTinh";
            this.txt_QuanTinh.Size = new System.Drawing.Size(163, 28);
            this.txt_QuanTinh.TabIndex = 3;
            this.txt_QuanTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuanTinh_KeyPress);
            // 
            // cbo_Silo
            // 
            this.cbo_Silo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Silo.FormattingEnabled = true;
            this.cbo_Silo.Items.AddRange(new object[] {
            "Silo 1",
            "Silo 2",
            "Silo 3",
            "Silo 4",
            "Silo 5",
            "Silo 6",
            "Silo 7",
            "Silo 8",
            "Silo 9",
            "Silo 10",
            "Silo 11",
            "Silo 12",
            "Silo 13",
            "Silo 14",
            "Silo 15"});
            this.cbo_Silo.Location = new System.Drawing.Point(250, 85);
            this.cbo_Silo.Name = "cbo_Silo";
            this.cbo_Silo.Size = new System.Drawing.Size(163, 31);
            this.cbo_Silo.TabIndex = 4;
            this.cbo_Silo.Text = "Chọn Silo";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(95, 209);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(105, 48);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Dong
            // 
            this.btn_Dong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(282, 209);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(104, 48);
            this.btn_Dong.TabIndex = 6;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_CaiDatFine
            // 
            this.AcceptButton = this.btn_Luu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.btn_Dong;
            this.ClientSize = new System.Drawing.Size(469, 291);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.cbo_Silo);
            this.Controls.Add(this.txt_QuanTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "frm_CaiDatFine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caifine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_QuanTinh;
        private System.Windows.Forms.ComboBox cbo_Silo;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Dong;
    }
}