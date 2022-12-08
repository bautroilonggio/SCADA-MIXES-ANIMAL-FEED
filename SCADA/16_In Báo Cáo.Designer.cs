
namespace SCADA
{
    partial class frm_InBaoCao
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
            this.rpv_BaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataCanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCan = new SCADA.DataSetCan();
            ((System.ComponentModel.ISupportInitialize)(this.DataCanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCan)).BeginInit();
            this.SuspendLayout();
            // 
            // rpv_BaoCao
            // 
            this.rpv_BaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_BaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpv_BaoCao.Name = "rpv_BaoCao";
            this.rpv_BaoCao.ServerReport.BearerToken = null;
            this.rpv_BaoCao.Size = new System.Drawing.Size(800, 450);
            this.rpv_BaoCao.TabIndex = 0;
            this.rpv_BaoCao.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // DataCanbindingSource
            // 
            this.DataCanBindingSource.DataMember = "DataCan";
            this.DataCanBindingSource.DataSource = this.DataSetCan;
            // 
            // DataSetCan
            // 
            this.DataSetCan.DataSetName = "DataSetCan";
            this.DataSetCan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_InBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpv_BaoCao);
            this.Name = "frm_InBaoCao";
            this.Text = "In_Báo_Cáo";
            ((System.ComponentModel.ISupportInitialize)(this.DataCanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCan)).EndInit();
            this.ResumeLayout(false);

        }

        private void InitializeComponent(string LoaiBaoCao)
        {
            this.components = new System.ComponentModel.Container();
            this.rpv_BaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataCanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCan = new SCADA.DataSetCan();
            ((System.ComponentModel.ISupportInitialize)(this.DataCanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCan)).BeginInit();
            this.SuspendLayout();
            // 
            // rpv_BaoCao
            // 
            this.rpv_BaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_BaoCao.LocalReport.ReportEmbeddedResource = LoaiBaoCao;
            this.rpv_BaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpv_BaoCao.Name = "rpv_BaoCao";
            this.rpv_BaoCao.ServerReport.BearerToken = null;
            this.rpv_BaoCao.Size = new System.Drawing.Size(800, 450);
            this.rpv_BaoCao.TabIndex = 0;
            this.rpv_BaoCao.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // DataCanBindingSource
            // 
            this.DataCanBindingSource.DataMember = "DataCan";
            this.DataCanBindingSource.DataSource = this.DataSetCan;
            // 
            // DataSetCan
            // 
            this.DataSetCan.DataSetName = "DataSetCan";
            this.DataSetCan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_InBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpv_BaoCao);
            this.Name = "frm_InBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In_Báo_Cáo";
            ((System.ComponentModel.ISupportInitialize)(this.DataCanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCan)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_BaoCao;
        private System.Windows.Forms.BindingSource DataCanBindingSource;
        private DataSetCan DataSetCan;
    }
}