using MetroFramework;
using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StabilityQualityControlSystemUI.Forms
{
    public partial class frmChamberMain : MetroForm
    {
        int id;
        BAL oB;
        public frmChamberMain()
        {
            oB = new BAL();
            InitializeComponent();
            lnkUser.Text = Global.UserName;
        }

        internal void frmChamber_Load(object sender, EventArgs e)
        {
            BindGrid(tbSearch.Text);
        }
        private void lnkBack_Click(object sender, EventArgs e)
        {
            frmDashboard _frmDashboard = new frmDashboard();
            _frmDashboard.Show();
            this.Hide();
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            BindGrid(tbSearch.Text);

        }

        private void lnkAddChamber_Click(object sender, EventArgs e)
        {
            frmChamber fr = new frmChamber();
            fr.ShowDialog();
        }

        private void lnkRefresh_Click(object sender, EventArgs e)
        {
            BindGrid(tbSearch.Text);

        }

        private void gridChamber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridChamber.SelectedCells.Count > 0)
            {
                int index = gridChamber.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridChamber.Rows[index];
                id = Convert.ToInt32(s.Cells["Id"].Value);

            }
        }

        private void lnkDeleteChamber_Click(object sender, EventArgs e)
        {
            DialogResult Res = MetroMessageBox.Show(this, "Are you sure you want to delete the selected Chamber?", "Delete Chamber", MessageBoxButtons.YesNo);
            if (Res == DialogResult.Yes)
                oB.bDeleteChamber(id);
        }

        private void gridChamber_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Chamber op = new Chamber();
            if (gridChamber.SelectedCells.Count > 0)
            {
                int index = gridChamber.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridChamber.Rows[index];
                op.Id = Convert.ToInt32(s.Cells["Id"].Value);
                op.Code = s.Cells["Code"].Value.ToString();
                op.Name = s.Cells["Name"].Value.ToString();
                op.Temperature = s.Cells["Temperature"].Value.ToString();
                op.Humidity = s.Cells["Humidity"].Value.ToString();
                op.Period = s.Cells["Period"].Value.ToString();

            }
            frmChamber p = new frmChamber(op);
            p.ShowDialog();
        }

        private void lnkLogout_Click(object sender, EventArgs e)
        {
            frmLogin fm = new frmLogin();
            fm.Show();
            this.Hide();
            Global.UserName = string.Empty;
        }
        public void BindGrid(string searchKeyword)
        {
            gridChamber.DataSource = oB.bGetChamber(0, searchKeyword);
            oB.HideGridColumns(gridChamber, new List<int> { 0, 1 });
        }
    }
}
