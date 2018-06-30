using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using StabilityQualityControlSystemUI.Forms;
using System;

namespace StabilityQualityControlSystemUI
{
    public partial class frmCountry : MetroForm
    {
        BAL oB;
        int Id;
        public frmCountry()
        {
            oB = new BAL();
            InitializeComponent();
        }
        public frmCountry(Country p)
        {
            oB = new BAL();
            InitializeComponent();
            Id = p.Id;
            txtCode.Text = p.Code;
            txtName.Text = p.Name;
        }

        private void frmCountry_Load(object sender, System.EventArgs e)
        {

        }

        private void txtSave_Click(object sender, System.EventArgs e)
        {
            Country o = new Country();
            o.Id = Id;
            o.Code = txtCode.Text;
            o.Name = txtName.Text;
            oB.bInsertUpdateCountry(o);
            this.Close();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
