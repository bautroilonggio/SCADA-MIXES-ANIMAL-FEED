using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SCADA
{
    public partial class frm_InBaoCao : Form
    {
        public frm_InBaoCao()
        {
            InitializeComponent();
        }

        public frm_InBaoCao(DataSet DataCan, string LoaiBaoCao)
        {

            InitializeComponent(LoaiBaoCao);
            DataCanBindingSource.DataSource = DataCan;
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataCan";
            //rds.Value = this.DataCanBindingSource;
            rds.Value = DataCan.Tables[0];
            rpv_BaoCao.LocalReport.DataSources.Clear();
            rpv_BaoCao.LocalReport.DataSources.Add(rds);
            rpv_BaoCao.LocalReport.Refresh();
            this.rpv_BaoCao.RefreshReport();
        }

        private void frm_InBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
