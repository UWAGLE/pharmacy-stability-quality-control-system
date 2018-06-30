using MetroFramework;
using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StabilityQualityControlSystemUI.Forms
{
    public partial class frmTestReportMain : MetroForm
    {
        int id, stabilityCheckId;
        BAL oB;
        public frmTestReportMain()
        {
            oB = new BAL();
            InitializeComponent();
            lnkUser.Text = Global.UserName;
        }

        internal void frmTestReport_Load(object sender, EventArgs e)
        {
            BindGridPlanner(txtFromDate.Text, txtToDate.Text);
        }
        private void lnkBack_Click(object sender, EventArgs e)
        {
            frmDashboard _frmDashboard = new frmDashboard();
            _frmDashboard.Show();
            this.Hide();
        }

        private void lnkAddTestReport_Click(object sender, EventArgs e)
        {
            StabilityMonthlyPlanner sm = new StabilityMonthlyPlanner();
            if (gridStabilityPlanner.SelectedCells.Count > 0)
            {
                int index = gridStabilityPlanner.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridStabilityPlanner.Rows[index];
                sm.StabilityCheckId = Convert.ToInt32(s.Cells["StabilityCheckId"].Value.ToString());
                sm.ProductName = s.Cells["ProductName"].Value.ToString();
                sm.BatchNo = s.Cells["BatchNo"].Value.ToString();
                sm.MfgDate = s.Cells["MfgDate"].Value.ToString();
                sm.ExpDate = s.Cells["ExpDate"].Value.ToString();
                sm.BatchSize = s.Cells["BatchSize"].Value.ToString();
                sm.Pack = s.Cells["Pack"].Value.ToString();
                sm.ShelfLife = s.Cells["ShelfLife"].Value.ToString();
                sm.ConditionInterval = s.Cells["ConditionInterval"].Value.ToString();
                sm.ItemCode = s.Cells["Itemcode"].Value.ToString();
                sm.Country = s.Cells["Country"].Value.ToString();
                sm.DueDate = s.Cells["DueDate"].Value.ToString();
                sm.MONTH = s.Cells["Month"].Value.ToString();
            }
            frmTestReport fr = new frmTestReport(sm);
            fr.ShowDialog();
        }

        private void lnkRefresh_Click(object sender, EventArgs e)
        {
            BindGrid(stabilityCheckId, 0);

        }

        private void gridTestReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkDeleteTestReport_Click(object sender, EventArgs e)
        {
            DialogResult Res = MetroMessageBox.Show(this, "Are you sure you want to delete the selected TestReport?", "Delete TestReport", MessageBoxButtons.YesNo);
            if (Res == DialogResult.Yes)
                oB.bDeleteTestReport(id);
        }

        private void gridTestReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TestReport op = new TestReport();
            StabilityMonthlyPlanner sm = new StabilityMonthlyPlanner();
            if (gridStabilityPlanner.SelectedCells.Count > 0)
            {
                int index = gridStabilityPlanner.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridStabilityPlanner.Rows[index];
                sm.StabilityCheckId = Convert.ToInt32(s.Cells["StabilityCheckId"].Value.ToString());
                sm.ProductName = s.Cells["ProductName"].Value.ToString();
                sm.BatchNo = s.Cells["BatchNo"].Value.ToString();
                sm.MfgDate = s.Cells["MfgDate"].Value.ToString();
                sm.ExpDate = s.Cells["ExpDate"].Value.ToString();
                sm.BatchSize = s.Cells["BatchSize"].Value.ToString();
                sm.Pack = s.Cells["Pack"].Value.ToString();
                sm.ShelfLife = s.Cells["ShelfLife"].Value.ToString();
                sm.ConditionInterval = s.Cells["ConditionInterval"].Value.ToString();
                sm.ItemCode = s.Cells["Itemcode"].Value.ToString();
                sm.Country = s.Cells["Country"].Value.ToString();
                sm.DueDate = s.Cells["DueDate"].Value.ToString();
                sm.MONTH = s.Cells["Month"].Value.ToString();
            }
            if (gridTestReport.SelectedCells.Count > 0)
            {
                int index = gridTestReport.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridTestReport.Rows[index];
                op.Id = Convert.ToInt32(s.Cells["Id"].Value);
                op.StabilityCheckId = Convert.ToInt32(s.Cells["StabilityCheckId"].Value);
                op.TestId = Convert.ToInt32(s.Cells["TestId"].Value);
                op.Initial = s.Cells["Initial"].Value.ToString();
                op.M1 = s.Cells["M1"].Value.ToString();
                op.M2 = s.Cells["M2"].Value.ToString();
                op.M3 = s.Cells["M3"].Value.ToString();
                op.M6 = s.Cells["M6"].Value.ToString();
                op.M9 = s.Cells["M9"].Value.ToString();
                op.M12 = s.Cells["M12"].Value.ToString();
                op.M18 = s.Cells["M18"].Value.ToString();
                op.M24 = s.Cells["M24"].Value.ToString();
                op.M30 = s.Cells["M30"].Value.ToString();
                op.M36 = s.Cells["M36"].Value.ToString();
                op.M42 = s.Cells["M42"].Value.ToString();
                op.M48 = s.Cells["M48"].Value.ToString();
                op.M60 = s.Cells["M60"].Value.ToString();
                op.M72 = s.Cells["M72"].Value.ToString();
            }
            frmTestReport p = new frmTestReport(op, sm);
            p.ShowDialog();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            BindGridPlanner(txtFromDate.Text, txtToDate.Text);
        }

        private void gridStabilityPlanner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridStabilityPlanner.SelectedCells.Count > 0)
            {
                int index = gridStabilityPlanner.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridStabilityPlanner.Rows[index];
                stabilityCheckId = Convert.ToInt32(s.Cells["stabilityCheckId"].Value);
                BindGrid(stabilityCheckId, 0);
            }
        }

        private void gridStabilityPlanner_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (gridStabilityPlanner.SelectedCells.Count > 0)
            {
                int index = gridStabilityPlanner.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridStabilityPlanner.Rows[index];
                stabilityCheckId = Convert.ToInt32(s.Cells["stabilityCheckId"].Value);
                BindGrid(stabilityCheckId, 0);
            }
        }

        private void lnkLogout_Click(object sender, EventArgs e)
        {
            frmLogin fm = new frmLogin();
            fm.Show();
            this.Hide();
            Global.UserName = string.Empty;
        }

        private void gridStabilityPlanner_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StabilityMonthlyPlanner op = new StabilityMonthlyPlanner();
            if (gridStabilityPlanner.SelectedCells.Count > 0)
            {
                int index = gridStabilityPlanner.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridStabilityPlanner.Rows[index];
                op.StabilityCheckId = Convert.ToInt32(s.Cells["StabilityCheckId"].Value.ToString());
                op.ProductName = s.Cells["ProductName"].Value.ToString();
                op.BatchNo = s.Cells["BatchNo"].Value.ToString();
                op.MfgDate = s.Cells["MfgDate"].Value.ToString();
                op.ExpDate = s.Cells["ExpDate"].Value.ToString();
                op.BatchSize = s.Cells["BatchSize"].Value.ToString();
                op.Pack = s.Cells["Pack"].Value.ToString();
                op.ShelfLife = s.Cells["ShelfLife"].Value.ToString();
                op.ConditionInterval = s.Cells["ConditionInterval"].Value.ToString();
                op.ItemCode = s.Cells["Itemcode"].Value.ToString();
                op.Country = s.Cells["Country"].Value.ToString();
                op.DueDate = s.Cells["DueDate"].Value.ToString();
                op.MONTH = s.Cells["Month"].Value.ToString();
            }
            frmTestReport p = new frmTestReport(op);
            p.ShowDialog();
        }
        public void BindGrid(int stabilityCheckId, int testID)
        {
            gridTestReport.DataSource = oB.bGetTestReport(stabilityCheckId, testID);
            oB.HideGridColumns(gridTestReport, new List<int> { 0, 1, 2 });
        }
        public void BindGridPlanner(string fromDate, string toDate)
        {
            gridStabilityPlanner.DataSource = oB.bGetStabilityPlannerReport(fromDate, toDate);
            oB.HideGridColumns(gridStabilityPlanner, new List<int> { 0 });
        }
    }
}
