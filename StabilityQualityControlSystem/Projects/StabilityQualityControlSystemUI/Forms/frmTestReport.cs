using MetroFramework;
using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using StabilityQualityControlSystemUI.Forms;
using System;
using System.Collections.Generic;
using System.Data;

namespace StabilityQualityControlSystemUI
{
    public partial class frmTestReport : MetroForm
    {
        BAL oB;
        int Id, StabilityCheckId, TestId;
        public frmTestReport()
        {
            oB = new BAL();
            InitializeComponent();
            BindDD();
        }

        public frmTestReport(StabilityMonthlyPlanner o)
        {
            oB = new BAL();
            InitializeComponent();
            BindDD();
            StabilityCheckId = o.StabilityCheckId;
            lblProductName.Text = o.ProductName;
            lblBatchNo.Text = o.BatchNo;
            lblMfgDate.Text = o.MfgDate;
            lblExpDate.Text = o.ExpDate;
            lblBatchSize.Text = o.BatchSize;
            lblPack.Text = o.Pack;
            lblShelfLife.Text = o.ShelfLife;
            lblConditionInterval.Text = o.ConditionInterval;
            lblItemCode.Text = o.ItemCode;
            lblCountry.Text = o.Country;
            lblDueDate.Text = o.DueDate + "-" + o.MONTH;

        }
        public frmTestReport(TestReport o, StabilityMonthlyPlanner o1)
        {
            oB = new BAL();
            InitializeComponent();
            BindDD();
            ClealAll();
            Id = o.Id;
            txtInitial.Text = o.Initial;
            StabilityCheckId = o.StabilityCheckId;
            ddlTest.SelectedValue = o.TestId;
            txtInitial.Text = o.Initial;
            txt1M.Text = o.M1;
            txt2M.Text = o.M2;
            txt3M.Text = o.M3;
            txt6M.Text = o.M6;
            txt9M.Text = o.M9;
            txt12M.Text = o.M12;
            txt18M.Text = o.M18;
            txt24M.Text = o.M24;
            txt30M.Text = o.M30;
            txt36M.Text = o.M36;
            txt42M.Text = o.M42;
            txt48M.Text = o.M48;
            txt60M.Text = o.M60;
            txt72M.Text = o.M72;

            lblProductName.Text = o1.ProductName;
            lblBatchNo.Text = o1.BatchNo;
            lblMfgDate.Text = o1.MfgDate;
            lblExpDate.Text = o1.ExpDate;
            lblBatchSize.Text = o1.BatchSize;
            lblPack.Text = o1.Pack;
            lblShelfLife.Text = o1.ShelfLife;
            lblConditionInterval.Text = o1.ConditionInterval;
            lblItemCode.Text = o1.ItemCode;
            lblCountry.Text = o1.Country;
            lblDueDate.Text = o1.DueDate + "-" + o1.MONTH;
        }

        private void frmTestReport_Load(object sender, System.EventArgs e)
        {
        }

        private void txtSave_Click(object sender, System.EventArgs e)
        {
            TestReport o = new TestReport();
            o.Id = Id;
            o.TestId = Convert.ToInt32(ddlTest.SelectedValue.ToString());
            o.StabilityCheckId = StabilityCheckId;
            o.Initial = txtInitial.Text;
            o.M1 = txt1M.Text;
            o.M2 = txt2M.Text;
            o.M3 = txt3M.Text;
            o.M6 = txt6M.Text;
            o.M9 = txt9M.Text;
            o.M12 = txt12M.Text;
            o.M18 = txt18M.Text;
            o.M24 = txt24M.Text;
            o.M30 = txt30M.Text;
            o.M36 = txt36M.Text;
            o.M42 = txt42M.Text;
            o.M48 = txt48M.Text;
            o.M60 = txt60M.Text;
            o.M72 = txt72M.Text;
            if (!oB.bInsertUpdateTestReport(o))
                MetroMessageBox.Show(this, "Test report already added generated for this record.");
            this.Close();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindDD()
        {
            ddlTest.DataSource = oB.bGetddlTest();
            ddlTest.DisplayMember = "Name";
            ddlTest.ValueMember = "Id";
        }

        private void ddlTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClealAll();
            int.TryParse(ddlTest.SelectedValue.ToString(), out TestId);
            List<TestReport> testReport = oB.bGetTestReport(StabilityCheckId, TestId);
            if (TestId != 0 && testReport.Count > 0)
            {
                Id = testReport[0].Id;
                txtInitial.Text = testReport[0].Initial;
                txt1M.Text = testReport[0].M1;
                txt2M.Text = testReport[0].M2;
                txt3M.Text = testReport[0].M3;
                txt6M.Text = testReport[0].M6;
                txt9M.Text = testReport[0].M9;
                txt12M.Text = testReport[0].M12;
                txt18M.Text = testReport[0].M18;
                txt24M.Text = testReport[0].M24;
                txt30M.Text = testReport[0].M30;
                txt36M.Text = testReport[0].M36;
                txt42M.Text = testReport[0].M42;
                txt48M.Text = testReport[0].M48;
                txt60M.Text = testReport[0].M60;
                txt72M.Text = testReport[0].M72;
            }
        }
        private void ClealAll()
        {
            txtInitial.Text = string.Empty;
            txt1M.Text = string.Empty;
            txt2M.Text = string.Empty;
            txt3M.Text = string.Empty;
            txt6M.Text = string.Empty;
            txt9M.Text = string.Empty;
            txt12M.Text = string.Empty;
            txt18M.Text = string.Empty;
            txt24M.Text = string.Empty;
            txt30M.Text = string.Empty;
            txt36M.Text = string.Empty;
            txt42M.Text = string.Empty;
            txt48M.Text = string.Empty;
            txt60M.Text = string.Empty;
            txt72M.Text = string.Empty;
        }
    }
}
