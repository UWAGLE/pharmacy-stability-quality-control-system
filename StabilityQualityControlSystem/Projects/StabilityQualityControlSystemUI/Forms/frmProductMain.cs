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
    public partial class frmProductMain : MetroForm
    {
        int id;
        BAL oB;
        public frmProductMain()
        {
            oB = new BAL();
            InitializeComponent();
            lnkUser.Text = Global.UserName;
        }

        internal void frmProduct_Load(object sender, EventArgs e)
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

        private void lnkAddProduct_Click(object sender, EventArgs e)
        {
            frmProduct fr = new frmProduct();
            fr.ShowDialog();
        }

        private void lnkRefresh_Click(object sender, EventArgs e)
        {
            BindGrid(tbSearch.Text);
        }

        private void gridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProduct.SelectedCells.Count > 0)
            {
                int index = gridProduct.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridProduct.Rows[index];
                id = Convert.ToInt32(s.Cells["Id"].Value);
            }
        }

        private void lnkDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult Res = MetroMessageBox.Show(this, "Are you sure you want to delete the selected product?", "Delete Product", MessageBoxButtons.YesNo);
            if (Res == DialogResult.Yes)
                oB.bDeleteProduct(id);
        }

        private void gridProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product op = new Product();
            if (gridProduct.SelectedCells.Count > 0)
            {
                int index = gridProduct.SelectedCells[0].RowIndex;
                DataGridViewRow s = gridProduct.Rows[index];
                op.Id = Convert.ToInt32(s.Cells["Id"].Value);
                op.Code = s.Cells["Code"].Value.ToString();
                op.Name = s.Cells["Name"].Value.ToString();
                op.LabelClaim = s.Cells["LabelClaim"].Value.ToString();
                op.APISource = s.Cells["APISource"].Value.ToString();
                op.PackingDetails = s.Cells["PackingDetails"].Value.ToString();
                op.Pack = s.Cells["Pack"].Value.ToString();
                op.ShelfLife = s.Cells["ShelfLife"].Value.ToString();
            }
            frmProduct p = new frmProduct(op);
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
            gridProduct.DataSource = oB.bGetProduct(0, searchKeyword);
            oB.HideGridColumns(gridProduct, new List<int> { 0, 1 });
        }
    }
}
