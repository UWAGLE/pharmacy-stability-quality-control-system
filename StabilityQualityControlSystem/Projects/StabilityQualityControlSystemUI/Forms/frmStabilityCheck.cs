using MetroFramework;
using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using StabilityQualityControlSystemUI.Forms;
using System;
using System.Data;

namespace StabilityQualityControlSystemUI
{
    public partial class frmStabilityCheck : MetroForm
    {
        BAL oB;
        int Id;
        public frmStabilityCheck()
        {
            oB = new BAL();
            InitializeComponent();
            BindDD();
        }
        public frmStabilityCheck(StabilityCheck o)
        {

            oB = new BAL();
            InitializeComponent();
            BindDD();
            Id = o.Id;
            ddlProduct.SelectedValue = o.ProductId;
            txtProtocolNo.Text = o.ProtocolNo;
            txtStudyReason.Text = o.StudyReason;
            txtRemark.Text = o.Remark;
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
            ddlBatch.SelectedValue = o.BatchId;
            ddlChamber.SelectedValue = o.ChamberId;
        }

        private void frmStabilityCheck_Load(object sender, System.EventArgs e)
        {
        }

        private void txtSave_Click(object sender, System.EventArgs e)
        {
            StabilityCheck o = new StabilityCheck();
            o.Id = Id;
            o.BatchId = int.Parse(ddlBatch.SelectedValue.ToString());
            o.ChamberId = int.Parse(ddlChamber.SelectedValue.ToString());
            o.ProtocolNo = txtProtocolNo.Text;
            o.StudyReason = txtStudyReason.Text;
            o.Remark = txtRemark.Text;
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
            if (!oB.bInsertUpdateStabilityCheck(o))
                MetroMessageBox.Show(this, "Stability check for this batch/chamber is already added.");
            this.Close();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindDD()
        {
            ddlProduct.DataSource = oB.bGetddlProduct();
            ddlProduct.DisplayMember = "Name";
            ddlProduct.ValueMember = "Id";

            ddlChamber.DataSource = oB.bGetddlChamber();
            ddlChamber.DisplayMember = "Name";
            ddlChamber.ValueMember = "Id";
        }

        private void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private DateTime CheckHolidayAndAddPeriod(ref DateTime IncubationDate, int interval)
        {
            if (IncubationDate.AddDays(interval).DayOfWeek == DayOfWeek.Sunday)
                IncubationDate = IncubationDate.AddDays(interval + 1);
            else
                IncubationDate = IncubationDate.AddDays(interval);
            return IncubationDate;
        }

        private void ddlBatch_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Batch oBatch = oB.bGetBatch(Convert.ToInt32(ddlBatch.SelectedValue), null)[0];
            DateTime IncubationDate = Convert.ToDateTime(oBatch.IncubationDate);
            lblInCubationDate.Text = string.Format("Incubation Date: {0}", IncubationDate.ToShortDateString());
            txt1M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 30).ToShortDateString();
            txt2M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 30).ToShortDateString();
            txt3M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 30).ToShortDateString();
            txt6M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 90).ToShortDateString();
            txt9M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 90).ToShortDateString();
            txt12M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 90).ToShortDateString();
            txt18M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 180).ToShortDateString();
            txt24M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 180).ToShortDateString();
            txt30M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 180).ToShortDateString();
            txt36M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 180).ToShortDateString();
            txt42M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 180).ToShortDateString();
            txt48M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 180).ToShortDateString();
            txt60M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 360).ToShortDateString();
            txt72M.Text = CheckHolidayAndAddPeriod(ref IncubationDate, 360).ToShortDateString();

        }

        private void ddlProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ddlProduct.SelectedIndex > 0)
            {
                ddlBatch.DataSource = oB.bGetddlBatch(ddlProduct.SelectedValue.ToString());
                ddlBatch.DisplayMember = "BatchNo";
                ddlBatch.ValueMember = "Id";
            }
        }
        
    }
}
