namespace StabilityQualityControlSystemUI.Forms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.Label1 = new System.Windows.Forms.Label();
            this.MetroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lnkCloseApplication = new MetroFramework.Controls.MetroLink();
            this.tbUserName = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(335, 294);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(729, 46);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "SIGMA LABORATORIES LIMITED, GOA";
            // 
            // MetroLabel1
            // 
            this.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MetroLabel1.AutoSize = true;
            this.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroLabel1.Location = new System.Drawing.Point(563, 353);
            this.MetroLabel1.Name = "MetroLabel1";
            this.MetroLabel1.Size = new System.Drawing.Size(186, 25);
            this.MetroLabel1.TabIndex = 21;
            this.MetroLabel1.Text = "Login to your account";
            // 
            // lnkCloseApplication
            // 
            this.lnkCloseApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCloseApplication.Image = ((System.Drawing.Image)(resources.GetObject("lnkCloseApplication.Image")));
            this.lnkCloseApplication.ImageSize = 32;
            this.lnkCloseApplication.Location = new System.Drawing.Point(1283, 19);
            this.lnkCloseApplication.Name = "lnkCloseApplication";
            this.lnkCloseApplication.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkCloseApplication.NoFocusImage")));
            this.lnkCloseApplication.Size = new System.Drawing.Size(35, 35);
            this.lnkCloseApplication.TabIndex = 3;
            this.lnkCloseApplication.TabStop = false;
            this.lnkCloseApplication.UseSelectable = true;
            this.lnkCloseApplication.Click += new System.EventHandler(this.lnkCloseApplication_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.tbUserName.CustomButton.Image = null;
            this.tbUserName.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.tbUserName.CustomButton.Name = "";
            this.tbUserName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tbUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUserName.CustomButton.TabIndex = 1;
            this.tbUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUserName.CustomButton.UseSelectable = true;
            this.tbUserName.CustomButton.Visible = false;
            this.tbUserName.DisplayIcon = true;
            this.tbUserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbUserName.Icon = ((System.Drawing.Image)(resources.GetObject("tbUserName.Icon")));
            this.tbUserName.Lines = new string[0];
            this.tbUserName.Location = new System.Drawing.Point(507, 393);
            this.tbUserName.MaxLength = 32767;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PromptText = "Username";
            this.tbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserName.SelectedText = "";
            this.tbUserName.SelectionLength = 0;
            this.tbUserName.SelectionStart = 0;
            this.tbUserName.ShortcutsEnabled = true;
            this.tbUserName.ShowClearButton = true;
            this.tbUserName.Size = new System.Drawing.Size(306, 36);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.UseSelectable = true;
            this.tbUserName.WaterMark = "Username";
            this.tbUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.DisplayIcon = true;
            this.tbPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbPassword.Icon = ((System.Drawing.Image)(resources.GetObject("tbPassword.Icon")));
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(507, 435);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.PromptText = "Password";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.ShowButton = true;
            this.tbPassword.ShowClearButton = true;
            this.tbPassword.Size = new System.Drawing.Size(306, 36);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.WaterMark = "Password";
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbPassword_ButtonClick);
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 634);
            this.ControlBox = false;
            this.Controls.Add(this.lnkCloseApplication);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.MetroLabel1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.Label1);
            this.Movable = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal MetroFramework.Controls.MetroTextBox tbUserName;
        internal MetroFramework.Controls.MetroLabel MetroLabel1;
        internal MetroFramework.Controls.MetroTextBox tbPassword;
        internal MetroFramework.Controls.MetroLink lnkCloseApplication;
    }
}