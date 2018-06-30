using MetroFramework;
using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StabilityQualityControlSystemUI.Forms
{
    public partial class frmUserMain : MetroForm
    {
        int id;
        BAL oB;
        public frmUserMain()
        {
            oB = new BAL();
            InitializeComponent();
            lnkUser.Text = Global.UserName;
        }

        internal void frmUser_Load(object sender, EventArgs e)
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

        private void lnkAddUser_Click(object sender, EventArgs e)
        {
            frmUser fr = new frmUser();
            fr.ShowDialog();
        }

        private void lnkRefresh_Click(object sender, EventArgs e)
        {
            BindGrid(tbSearch.Text);

        }

        private void gridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUser.SelectedCells.Count > 0)
            {
                int index = gridUser.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridUser.Rows[index];
                id = Convert.ToInt32(s.Cells["Id"].Value);
            }
        }

        private void lnkDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult Res = MetroMessageBox.Show(this, "Are you sure you want to delete the selected User?", "Delete User", MessageBoxButtons.YesNo);
            if (Res == DialogResult.Yes)
                oB.bDeleteUser(id);
        }

        private void gridUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            User op = new User();
            if (gridUser.SelectedCells.Count > 0)
            {
                int index = gridUser.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridUser.Rows[index];
                op.Id = Convert.ToInt32(s.Cells["Id"].Value);
                op.UserName = s.Cells["UserName"].Value.ToString();
                op.FirstName = s.Cells["FirstName"].Value.ToString();
                op.LastName = s.Cells["LastName"].Value.ToString();
                op.Password = s.Cells["Password"].Value.ToString();
                op.RoleId = Convert.ToInt16(s.Cells["RoleId"].Value.ToString());
            }
            frmUser p = new frmUser(op);
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
            gridUser.DataSource = oB.bGetUser(0, searchKeyword);
            oB.HideGridColumns(gridUser, new List<int> { 0, 1 });
        }

    }
}
