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
    public partial class frmBatchMain : MetroForm
    {
        int id;
        BAL oB;
        public frmBatchMain()
        {
            oB = new BAL();
            InitializeComponent();
            lnkUser.Text = Global.UserName;
        }

        internal void frmBatch_Load(object sender, EventArgs e)
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

        private void lnkAddBatch_Click(object sender, EventArgs e)
        {
            frmBatch fr = new frmBatch();
            fr.ShowDialog();
        }

        private void lnkRefresh_Click(object sender, EventArgs e)
        {
            BindGrid(tbSearch.Text);
        }

        private void gridBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridBatch.SelectedCells.Count > 0)
            {
                int index = gridBatch.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridBatch.Rows[index];
                id = Convert.ToInt32(s.Cells["Id"].Value);

            }
        }

        private void lnkDeleteBatch_Click(object sender, EventArgs e)
        {
            DialogResult Res = MetroMessageBox.Show(this, "Are you sure you want to delete the selected Batch?", "Delete Batch", MessageBoxButtons.YesNo);
            if (Res == DialogResult.Yes)
                oB.bDeleteBatch(id);
        }

        private void gridBatch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Batch op = new Batch();
            if (gridBatch.SelectedCells.Count > 0)
            {
                int index = gridBatch.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridBatch.Rows[index];
                op.Id = Convert.ToInt32(s.Cells["Id"].Value);
                op.BatchNo = s.Cells["BatchNo"].Value.ToString();
                op.ProductId = Convert.ToInt32(s.Cells["ProductId"].Value);
                op.ExpDate = s.Cells["ExpDate"].Value.ToString();
                op.BatchSize = s.Cells["BatchSize"].Value.ToString();
                op.ReleaseDate = s.Cells["ReleaseDate"].Value.ToString();
                op.IncubationDate = s.Cells["IncubationDate"].Value.ToString();
                op.CountryId = Convert.ToInt32(s.Cells["CountryId"].Value);
                op.Type = Convert.ToInt32(s.Cells["Type"].Value);
                op.OtherInfo = s.Cells["OtherInfo"].Value.ToString();
                op.MfgDate = s.Cells["MfgDate"].Value.ToString();
            }
            frmBatch p = new frmBatch(op);
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
            gridBatch.DataSource = oB.bGetBatch(0, searchKeyword);
            oB.HideGridColumns(gridBatch, new List<int> { 0, 1, 2, 3 });
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
