using MetroFramework;
using MetroFramework.Forms;
using StabilityBAL;
using System;
using System.Windows.Forms;

namespace StabilityQualityControlSystemUI.Forms
{
    public partial class frmDashboard : MetroForm
    {
        BAL oB;
        public frmDashboard()
        {
            InitializeComponent();
            lnkUser.Text = Global.UserName;
            if (Global.Role != 2)
                tileUser.Enabled = false;
            oB = new BAL();
            ddlperiod.SelectedIndex = 0;
            BindGridDueList(DateTime.Now.Date.ToShortDateString(), DateTime.Now.Date.ToShortDateString());
        }

        private void tileProduct_Click(object sender, EventArgs e)
        {
            DisableButtons();
            frmProductMain fm = new frmProductMain();
            fm.Show();
            this.Hide();
        }

        private void tileChamber_Click(object sender, EventArgs e)
        {
            DisableButtons();
            frmChamberMain fm = new frmChamberMain();
            fm.Show();
            this.Hide();
        }

        private void tileCountry_Click(object sender, EventArgs e)
        {
            DisableButtons();
            frmCountryMain fm = new frmCountryMain();
            fm.Show();
            this.Hide();
        }
        private void tileBatch_Click(object sender, EventArgs e)
        {
            DisableButtons();
            frmBatchMain fm = new frmBatchMain();
            fm.Show();
            this.Hide();
        }
        private void tileTest_Click(object sender, EventArgs e)
        {
            DisableButtons();
            frmTestMain fm = new frmTestMain();
            fm.Show();
            this.Hide();
        }

        private void tileStabilityCheck_Click(object sender, EventArgs e)
        {
            DisableButtons();
            frmStabilityCheckMain fm = new frmStabilityCheckMain();
            fm.Show();
            this.Hide();
        }
        private void tileStabilityTestReport_Click(object sender, EventArgs e)
        {
            callTestReport();
        }
        private void callTestReport()
        {
            DisableButtons();
            frmTestReportMain fm = new frmTestReportMain();
            fm.Show();
            this.Hide();
        }

        private void tileUser_Click(object sender, EventArgs e)
        {
            DisableButtons();
            frmUserMain fm = new frmUserMain();
            fm.Show();
            this.Hide();
        }
        private void DisableButtons()
        {
            tileProduct.Enabled = false;
            tileChamber.Enabled = false;
            tileCountry.Enabled = false;
            tileBatch.Enabled = false;
            tileTestMaster.Enabled = false;
            tileStabilityCheck.Enabled = false;
            tileStabilityTestReport.Enabled = false;
            tileUser.Enabled = false;
            tileReport.Enabled = false;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void lnkLogout_Click(object sender, EventArgs e)
        {
            frmLogin fm = new frmLogin();
            fm.Show();
            this.Hide();
            Global.UserName = string.Empty;
        }

        private void tileTestMaster_Click(object sender, EventArgs e)
        {
            DisableButtons();
            frmTestMain fm = new frmTestMain();
            fm.Show();
            this.Hide();
        }

        private void tileReport_Click(object sender, EventArgs e)
        {
            DisableButtons();
            frmReportMain fm = new frmReportMain();
            fm.Show();
            this.Hide();
        }
        public void BindGridDueList(string fromDate, string toDate)
        {
            gridDueList.DataSource = oB.bGetStabilityDueReport(fromDate, toDate);
        }

        private void ddlperiod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlperiod.SelectedIndex == 0)
                BindGridDueList(DateTime.Now.Date.ToShortDateString(), DateTime.Now.Date.ToShortDateString());
            else if (ddlperiod.SelectedIndex == 1)
                BindGridDueList(DateTime.Now.AddDays(1).Date.ToShortDateString(), DateTime.Now.AddDays(1).Date.ToShortDateString());
            else if (ddlperiod.SelectedIndex == 2)
                BindGridDueList(DateTime.Now.Date.ToShortDateString(), DateTime.Now.AddDays(7).Date.ToShortDateString());
        }

        private void gridDueList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            callTestReport();
        }

        private void tileDueList_Click(object sender, EventArgs e)
        {
            callTestReport();
        }
    }
}
