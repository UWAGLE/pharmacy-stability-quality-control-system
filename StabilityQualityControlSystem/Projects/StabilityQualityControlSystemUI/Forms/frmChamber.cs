using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using StabilityQualityControlSystemUI.Forms;
using System;

namespace StabilityQualityControlSystemUI
{
    public partial class frmChamber : MetroForm
    {
        BAL oB;
        int Id;
        public frmChamber()
        {
            oB = new BAL();
            InitializeComponent();
        }
        public frmChamber(Chamber p)
        {
            oB = new BAL();
            InitializeComponent();
            Id = p.Id;
            txtCode.Text = p.Code;
            txtName.Text = p.Name;
            txtHumidity.Text = p.Humidity;
            txtTemperature.Text = p.Temperature;
            txtPeriod.Text = p.Period;
        }

        private void frmChamber_Load(object sender, System.EventArgs e)
        {

        }

        private void txtSave_Click(object sender, System.EventArgs e)
        {
            Chamber o = new Chamber();
            o.Id = Id;
            o.Code = txtCode.Text;
            o.Name = txtName.Text;
            o.Temperature = txtTemperature.Text;
            o.Humidity = txtHumidity.Text;
            o.Period = txtPeriod.Text;
            o.ModifiedById = Global.UserId;
            oB.bInsertUpdateChamber(o);
            this.Close();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
