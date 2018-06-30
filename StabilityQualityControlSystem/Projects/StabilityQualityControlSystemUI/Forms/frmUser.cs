using MetroFramework.Forms;
using StabilityBAL;
using StabilityInterface;
using StabilityQualityControlSystemUI.Forms;
using System;

namespace StabilityQualityControlSystemUI
{
    public partial class frmUser : MetroForm
    {
        BAL oB;
        int Id;
        public frmUser()
        {
            oB = new BAL();
            InitializeComponent();
            BindDD();
        }
        public frmUser(User p)
        {
            oB = new BAL();
            InitializeComponent();
            BindDD();
            Id = p.Id;
            txtUserName.Text = p.UserName;
            txtFirstName.Text = p.FirstName;
            txtLastName.Text = p.LastName;
            ddlRole.SelectedValue = p.RoleId;
            txtPassword.Text = p.Password;
        }

        private void frmUser_Load(object sender, System.EventArgs e)
        {

        }

        private void txtSave_Click(object sender, System.EventArgs e)
        {
            User o = new User();
            o.Id = Id;
            o.UserName = txtUserName.Text;
            o.FirstName = txtFirstName.Text;
            o.LastName = txtLastName.Text;
            o.RoleId = Convert.ToInt16(ddlRole.SelectedIndex.ToString());
            o.Password = txtPassword.Text;
            oB.bInsertUpdateUser(o);
            this.Close();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindDD()
        {
            ddlRole.Items.Add(new { Id = 0, Name = "Select Role" });
            ddlRole.Items.Add(new { Id = 1, Name = "User" });
            ddlRole.Items.Add(new { Id = 2, Name = "Admin" });
            ddlRole.ValueMember = "Id";
            ddlRole.DisplayMember = "Name";
        }
    }
}
