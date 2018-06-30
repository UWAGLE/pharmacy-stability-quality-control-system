using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using StabilityQualityControlSystemUI.Forms;
using System;
using System.Data;

namespace StabilityQualityControlSystemUI
{
    public partial class frmBatch : MetroForm
    {
        BAL oB;
        int Id;
        public frmBatch()
        {
            oB = new BAL();
            InitializeComponent();
            BindDD();
        }
        public frmBatch(Batch p)
        {

            oB = new BAL();
            InitializeComponent();
            BindDD();
            Id = p.Id;
            txtBatchSize.Text = p.BatchSize;
            txtBatchNo.Text = p.BatchNo;
            ddlProduct.SelectedValue = p.ProductId;
            txtExpDate.Text = p.ExpDate;
            txtBatchNo.Text = p.BatchNo;
            txtReleaseDate.Text = p.ReleaseDate;
            txtIncubationDate.Text = p.IncubationDate;
            ddlCountry.SelectedValue = p.CountryId;
            ddlType.SelectedValue = p.Type;
            txtOtherInfo.Text = p.OtherInfo;
            txtMfgDate.Text = p.MfgDate;
        }

        private void frmBatch_Load(object sender, System.EventArgs e)
        {
        }

        private void txtSave_Click(object sender, System.EventArgs e)
        {
            Batch o = new Batch();
            o.Id = Id;
            o.BatchNo = txtBatchNo.Text;
            o.ProductId = int.Parse(ddlProduct.SelectedValue.ToString());
            o.ExpDate = txtExpDate.Text;
            o.BatchSize = txtBatchSize.Text;
            o.ReleaseDate = txtReleaseDate.Text;
            o.IncubationDate = txtIncubationDate.Text;
            o.CountryId = int.Parse(ddlCountry.SelectedValue.ToString());
            o.Type = int.Parse(ddlType.SelectedValue.ToString());
            o.OtherInfo = txtOtherInfo.Text;
            o.MfgDate = txtMfgDate.Text;

            oB.bInsertUpdateBatch(o);
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

            ddlCountry.DataSource = oB.bGetddlCountry();
            ddlCountry.DisplayMember = "Name";
            ddlCountry.ValueMember = "Id";

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            DataRow r = dt.NewRow();
            r["Id"] = 1;
            r["Name"] = "Type1";
            dt.Rows.Add(r);
            ddlType.DataSource = dt;
            ddlType.DisplayMember = "Name";
            ddlType.ValueMember = "Id";
        }
    }
}
