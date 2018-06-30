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
    public partial class frmLogin : MetroForm
    {
        BAL oB;
        public frmLogin()
        {
            oB = new BAL();
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_ButtonClick(object sender, EventArgs e)
        {

            List<User> user = oB.bGetUser(0, null, tbUserName.Text, tbPassword.Text);
            if (user.Count > 0)
            {
                Global.UserName = string.Format("Welcome, {0} {1}", user[0].FirstName, user[0].LastName);
                Global.Role = user[0].RoleId;
                Global.UserId = user[0].Id;
                frmDashboard _frmDashboard = new frmDashboard();
                _frmDashboard.Show();
                this.Hide();
            }
            else
                MetroMessageBox.Show(this, "Wrong Username/Password!?", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lnkCloseApplication_Click(object sender, EventArgs e)
        {
            DialogResult Res = MetroMessageBox.Show(this, "Are you sure you want to exit the application??", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Res == DialogResult.Yes)
                Application.Exit();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
        }
    }
}
