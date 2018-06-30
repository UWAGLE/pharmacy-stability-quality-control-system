using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using StabilityQualityControlSystemUI.Forms;
using System;

namespace StabilityQualityControlSystemUI
{
    public partial class frmProduct : MetroForm
    {
        BAL oB;
        int Id;
        public frmProduct()
        {
            oB = new BAL();
            InitializeComponent();
        }
        public frmProduct(Product p)
        {
            oB = new BAL();
            InitializeComponent();
            Id = p.Id;
            txtApiSource.Text = p.APISource;
            txtCode.Text = p.Code;
            txtLabel.Text = p.LabelClaim;
            txtName.Text = p.Name;
            txtPack.Text = p.Pack;
            txtPackingDetails.Text = p.PackingDetails;
            txtShelfLife.Text = p.ShelfLife;
        }

        private void frmProduct_Load(object sender, System.EventArgs e)
        {

        }

        private void txtSave_Click(object sender, System.EventArgs e)
        {
            Product o = new Product();
            o.Id = Id;
            o.APISource = txtApiSource.Text;
            o.Code = txtCode.Text;
            o.LabelClaim = txtLabel.Text;
            o.ModifiedById = Global.UserId;
            o.Name = txtName.Text;
            o.PackingDetails = txtPackingDetails.Text;
            o.Pack = txtPack.Text;
            o.ShelfLife = txtShelfLife.Text;
            oB.bInsertUpdateProduct(o);
            this.Close();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
