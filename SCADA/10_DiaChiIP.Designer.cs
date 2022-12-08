
namespace SCADA
{
    partial class frm_DiaChiIP
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
            this.txt_DiaChiIP = new System.Windows.Forms.TextBox();
            this.btn_KetNoi = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(98, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "ĐIỀN ĐỊA CHỈ IP";
            // 
            // txt_DiaChiIP
            // 
            this.txt_DiaChiIP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChiIP.Location = new System.Drawing.Point(133, 77);
            this.txt_DiaChiIP.Multiline = true;
            this.txt_DiaChiIP.Name = "txt_DiaChiIP";
            this.txt_DiaChiIP.Size = new System.Drawing.Size(216, 32);
            this.txt_DiaChiIP.TabIndex = 6;
            this.txt_DiaChiIP.Text = "169.254.157.213";
            this.txt_DiaChiIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DiaChiIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiaChiIP_KeyPress);
            // 
            // btn_KetNoi
            // 
            this.btn_KetNoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KetNoi.Location = new System.Drawing.Point(41, 146);
            this.btn_KetNoi.Name = "btn_KetNoi";
            this.btn_KetNoi.Size = new System.Drawing.Size(127, 45);
            this.btn_KetNoi.TabIndex = 7;
            this.btn_KetNoi.Text = "Kết nối";
            this.btn_KetNoi.UseVisualStyleBackColor = true;
            this.btn_KetNoi.Click += new System.EventHandler(this.btn_KetNoi_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(199, 146);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(137, 45);
            this.btn_Dong.TabIndex = 8;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_DiaChiIP
            // 
            this.AcceptButton = this.btn_KetNoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.btn_Dong;
            this.ClientSize = new System.Drawing.Size(391, 225);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_KetNoi);
            this.Controls.Add(this.txt_DiaChiIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_DiaChiIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiaChiIP";
            this.Load += new System.EventHandler(this.frm_DiaChiIP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DiaChiIP;
        private System.Windows.Forms.Button btn_KetNoi;
        private System.Windows.Forms.Button btn_Dong;
    }
}