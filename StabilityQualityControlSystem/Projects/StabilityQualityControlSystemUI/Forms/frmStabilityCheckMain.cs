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
    public partial class frmStabilityCheckMain : MetroForm
    {
        int id;
        BAL oB;
        public frmStabilityCheckMain()
        {
            oB = new BAL();
            InitializeComponent();
            lnkUser.Text = Global.UserName;
        }

        internal void frmStabilityCheck_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void lnkBack_Click(object sender, EventArgs e)
        {
            frmDashboard _frmDashboard = new frmDashboard();
            _frmDashboard.Show();
            this.Hide();
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            BindGrid();
        }

        private void lnkAddStabilityCheck_Click(object sender, EventArgs e)
        {
            frmStabilityCheck fr = new frmStabilityCheck();
            fr.ShowDialog();
        }

        private void lnkRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void gridStabilityCheck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridStabilityCheck.SelectedCells.Count > 0)
            {
                int index = gridStabilityCheck.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridStabilityCheck.Rows[index];
                id = Convert.ToInt32(s.Cells["Id"].Value);

            }
        }

        private void lnkDeleteStabilityCheck_Click(object sender, EventArgs e)
        {
            DialogResult Res = MetroMessageBox.Show(this, "Are you sure you want to delete the selected StabilityCheck?", "Delete StabilityCheck", MessageBoxButtons.YesNo);
            if (Res == DialogResult.Yes)
                oB.bDeleteStabilityCheck(id);
        }

        private void gridStabilityCheck_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StabilityCheck op = new StabilityCheck();
            if (gridStabilityCheck.SelectedCells.Count > 0)
            {
                int index = gridStabilityCheck.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridStabilityCheck.Rows[index];
                op.Id = Convert.ToInt32(s.Cells["Id"].Value);
                op.BatchId = Convert.ToInt32(s.Cells["BatchId"].Value);
                op.ChamberId = Convert.ToInt32(s.Cells["ChamberId"].Value);
                op.ProductId = Convert.ToInt32(s.Cells["ProductId"].Value);
                op.StudyReason = s.Cells["StudyReason"].Value.ToString();
                op.ProtocolNo = s.Cells["ProtocolNo"].Value.ToString();
                op.Remark = s.Cells["Remark"].Value.ToString();
                op.M1 = s.Cells["M1"].Value.ToString();
                op.M2 = s.Cells["M2"].Value.ToString();
                op.M3 = s.Cells["M3"].Value.ToString();
                op.M6 = s.Cells["M6"].Value.ToString();
                op.M9 = s.Cells["M9"].Value.ToString();
                op.M12 = s.Cells["M12"].Value.ToString();
                op.M18 = s.Cells["M18"].Value.ToString();
                op.M24 = s.Cells["M24"].Value.ToString();
                op.M30 = s.Cells["M30"].Value.ToString();
                op.M36 = s.Cells["M36"].Value.ToString();
                op.M42 = s.Cells["M42"].Value.ToString();
                op.M48 = s.Cells["M48"].Value.ToString();
                op.M60 = s.Cells["M60"].Value.ToString();
                op.M72 = s.Cells["M72"].Value.ToString();
            }
            frmStabilityCheck p = new frmStabilityCheck(op);
            p.ShowDialog();
        }

        private void lnkLogout_Click(object sender, EventArgs e)
        {
            frmLogin fm = new frmLogin();
            fm.Show();
            this.Hide();
            Global.UserName = string.Empty;
        }
        public void BindGrid()
        {
            gridStabilityCheck.DataSource = oB.bGetStabilityCheck(0);
            oB.HideGridColumns(gridStabilityCheck, new List<int> { 0,1,2,3 });
        }
    }
}
