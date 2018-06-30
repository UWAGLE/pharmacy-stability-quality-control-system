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
    public partial class frmCountryMain : MetroForm
    {
        int id;
        BAL oB;
        public frmCountryMain()
        {
            oB = new BAL();
            InitializeComponent();
            lnkUser.Text = Global.UserName;
        }

        internal void frmCountry_Load(object sender, EventArgs e)
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

        private void lnkAddCountry_Click(object sender, EventArgs e)
        {
            frmCountry fr = new frmCountry();
            fr.ShowDialog();
        }

        private void lnkRefresh_Click(object sender, EventArgs e)
        {
            BindGrid(tbSearch.Text);
        }

        private void gridCountry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCountry.SelectedCells.Count > 0)
            {
                int index = gridCountry.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridCountry.Rows[index];
                id = Convert.ToInt32(s.Cells["Id"].Value);

            }
        }

        private void lnkDeleteCountry_Click(object sender, EventArgs e)
        {
            DialogResult Res = MetroMessageBox.Show(this, "Are you sure you want to delete the selected Country?", "Delete Country", MessageBoxButtons.YesNo);
            if (Res == DialogResult.Yes)
                oB.bDeleteCountry(id);
        }

        private void gridCountry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Country op = new Country();
            if (gridCountry.SelectedCells.Count > 0)
            {
                int index = gridCountry.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridCountry.Rows[index];
                op.Id = Convert.ToInt32(s.Cells["Id"].Value);
                op.Code = s.Cells["Code"].Value.ToString();
                op.Name = s.Cells["Name"].Value.ToString();
            }
            frmCountry p = new frmCountry(op);
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
            gridCountry.DataSource = oB.bGetCountry(0, searchKeyword);
            oB.HideGridColumns(gridCountry, new List<int> { 0 });
        }
    }
}
