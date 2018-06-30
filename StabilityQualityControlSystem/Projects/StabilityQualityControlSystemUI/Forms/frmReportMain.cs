using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using StabilityBAL;
using System;
using System.IO;
using System.Windows.Forms;

namespace StabilityQualityControlSystemUI.Forms
{
    public partial class frmReportMain : MetroForm
    {
        int id;
        BAL oB;
        public frmReportMain()
        {
            oB = new BAL();
            InitializeComponent();
            lnkUser.Text = Global.UserName;
        }

        internal void frmCountry_Load(object sender, EventArgs e)
        {

        }
        private void lnkBack_Click(object sender, EventArgs e)
        {
            frmDashboard _frmDashboard = new frmDashboard();
            _frmDashboard.Show();
            this.Hide();
        }



        private void lnkLogout_Click(object sender, EventArgs e)
        {
            frmLogin fm = new frmLogin();
            fm.Show();
            this.Hide();
            Global.UserName = string.Empty;
        }

        private void rvMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.rvMain.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("dsStabilitySamplesMonthlyPlanner", oB.bGetStabilityPlannerReport(txtFromDate.Text, txtToDate.Text));
            this.rvMain.LocalReport.DataSources.Add(rds);
            string exeFolder = Application.StartupPath.Replace(@"\bin\Debug", string.Empty).Replace(@"\bin\Release", string.Empty);
            rvMain.LocalReport.ReportPath = Path.Combine(exeFolder, @"Reports/rptStabilitySamplesMonthlyPlanner.rdlc");
            this.rvMain.RefreshReport();
        }
    }
}
