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
    public partial class frmTestMain : MetroForm
    {
        int id;
        BAL oB;
        public frmTestMain()
        {
            oB = new BAL();
            InitializeComponent();
            lnkUser.Text = Global.UserName;
        }

        internal void frmTest_Load(object sender, EventArgs e)
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

        private void lnkAddTest_Click(object sender, EventArgs e)
        {
            frmTest fr = new frmTest();
            fr.ShowDialog();
        }

        private void lnkRefresh_Click(object sender, EventArgs e)
        {
            BindGrid(tbSearch.Text);
        }

        private void gridTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridTest.SelectedCells.Count > 0)
            {
                int index = gridTest.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridTest.Rows[index];
                id = Convert.ToInt32(s.Cells["Id"].Value);

            }
        }

        private void lnkDeleteTest_Click(object sender, EventArgs e)
        {
            DialogResult Res = MetroMessageBox.Show(this, "Are you sure you want to delete the selected Test?", "Delete Test", MessageBoxButtons.YesNo);
            if (Res == DialogResult.Yes)
                oB.bDeleteTest(id);
        }

        private void gridTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Test op = new Test();
            if (gridTest.SelectedCells.Count > 0)
            {
                int index = gridTest.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridTest.Rows[index];
                op.Id = Convert.ToInt32(s.Cells["Id"].Value);
                op.Code = s.Cells["Code"].Value.ToString();
                op.Name = s.Cells["Name"].Value.ToString();
                op.Specification = s.Cells["Specification"].Value.ToString();
            }
            frmTest p = new frmTest(op);
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
            gridTest.DataSource = oB.bGetTest(0, searchKeyword);
            oB.HideGridColumns(gridTest, new List<int> { 0 });
        }
    }

}
