using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using StabilityQualityControlSystemUI.Forms;
using System;

namespace StabilityQualityControlSystemUI
{
    public partial class frmTest : MetroForm
    {
        BAL oB;
        int Id;
        public frmTest()
        {
            oB = new BAL();
            InitializeComponent();
        }
        public frmTest(Test p)
        {
            oB = new BAL();
            InitializeComponent();
            Id = p.Id;
            txtCode.Text = p.Code;
            txtName.Text = p.Name;
            txtSpecification.Text = p.Specification;
        }

        private void frmTest_Load(object sender, System.EventArgs e)
        {

        }

        private void txtSave_Click(object sender, System.EventArgs e)
        {
            Test o = new Test();
            o.Id = Id;
            o.Code = txtCode.Text;
            o.Name = txtName.Text;
            o.Specification = txtSpecification.Text;
            oB.bInsertUpdateTest(o);
            this.Close();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
