namespace StabilityQualityControlSystemUI.Forms
{
    partial class frmUserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.gridUser = new MetroFramework.Controls.MetroGrid();
            this.lnkRefresh = new MetroFramework.Controls.MetroLink();
            this.lnkDeleteUser = new MetroFramework.Controls.MetroLink();
            this.lnkAddUser = new MetroFramework.Controls.MetroLink();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.lnkLogout = new MetroFramework.Controls.MetroLink();
            this.lnkUser = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.tbSearch.CustomButton.Image = null;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.CustomButton.Visible = false;
            this.tbSearch.DisplayIcon = true;
            this.tbSearch.Icon = ((System.Drawing.Image)(resources.GetObject("tbSearch.Icon")));
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(111, 81);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PromptText = "Search User";
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.ShowClearButton = true;
            this.tbSearch.Size = new System.Drawing.Size(234, 26);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMark = "Search User";
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // gridUser
            // 
            this.gridUser.AllowUserToAddRows = false;
            this.gridUser.AllowUserToDeleteRows = false;
            this.gridUser.AllowUserToResizeRows = false;
            this.gridUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUser.EnableHeadersVisualStyles = false;
            this.gridUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridUser.Location = new System.Drawing.Point(111, 113);
            this.gridUser.Name = "gridUser";
            this.gridUser.ReadOnly = true;
            this.gridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUser.Size = new System.Drawing.Size(1200, 434);
            this.gridUser.TabIndex = 10;
            this.gridUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUser_CellClick);
            this.gridUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUser_CellDoubleClick);
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lnkRefresh.Image")));
            this.lnkRefresh.ImageSize = 32;
            this.lnkRefresh.Location = new System.Drawing.Point(677, 67);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(35, 35);
            this.lnkRefresh.TabIndex = 11;
            this.lnkRefresh.UseSelectable = true;
            this.lnkRefresh.Click += new System.EventHandler(this.lnkRefresh_Click);
            // 
            // lnkDeleteUser
            // 
            this.lnkDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkDeleteUser.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkDeleteUser.Image = global::StabilityQualityControlSystemUI.Properties.Resources.lnkDelUser_Image;
            this.lnkDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDeleteUser.ImageSize = 50;
            this.lnkDeleteUser.Location = new System.Drawing.Point(550, 67);
            this.lnkDeleteUser.Name = "lnkDeleteUser";
            this.lnkDeleteUser.Size = new System.Drawing.Size(121, 40);
            this.lnkDeleteUser.TabIndex = 9;
            this.lnkDeleteUser.Text = "Delete User";
            this.lnkDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDeleteUser.UseSelectable = true;
            this.lnkDeleteUser.Click += new System.EventHandler(this.lnkDeleteUser_Click);
            // 
            // lnkAddUser
            // 
            this.lnkAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkAddUser.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkAddUser.Image = global::StabilityQualityControlSystemUI.Properties.Resources.lnkReg_Image;
            this.lnkAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAddUser.ImageSize = 50;
            this.lnkAddUser.Location = new System.Drawing.Point(430, 67);
            this.lnkAddUser.Name = "lnkAddUser";
            this.lnkAddUser.Size = new System.Drawing.Size(114, 40);
            this.lnkAddUser.TabIndex = 8;
            this.lnkAddUser.Text = "Add User";
            this.lnkAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkAddUser.UseSelectable = true;
            this.lnkAddUser.Click += new System.EventHandler(this.lnkAddUser_Click);
            // 
            // lnkBack
            // 
            this.lnkBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkBack.Image = ((System.Drawing.Image)(resources.GetObject("lnkBack.Image")));
            this.lnkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkBack.ImageSize = 32;
            this.lnkBack.Location = new System.Drawing.Point(3, 8);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(202, 35);
            this.lnkBack.TabIndex = 4;
            this.lnkBack.Text = "Manage Users";
            this.lnkBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // lnkLogout
            // 
            this.lnkLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkLogout.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogout.Image")));
            this.lnkLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLogout.ImageSize = 20;
            this.lnkLogout.Location = new System.Drawing.Point(1281, 8);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkLogout.NoFocusImage")));
            this.lnkLogout.Size = new System.Drawing.Size(94, 35);
            this.lnkLogout.TabIndex = 55;
            this.lnkLogout.TabStop = false;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkLogout.UseSelectable = true;
            this.lnkLogout.UseStyleColors = true;
            this.lnkLogout.Click += new System.EventHandler(this.lnkLogout_Click);
            // 
            // lnkUser
            // 
            this.lnkUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkUser.AutoSize = true;
            this.lnkUser.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkUser.Image = ((System.Drawing.Image)(resources.GetObject("lnkUser.Image")));
            this.lnkUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkUser.ImageSize = 32;
            this.lnkUser.Location = new System.Drawing.Point(1039, 8);
            this.lnkUser.Name = "lnkUser";
            this.lnkUser.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkUser.NoFocusImage")));
            this.lnkUser.Size = new System.Drawing.Size(40, 35);
            this.lnkUser.TabIndex = 54;
            this.lnkUser.TabStop = false;
            this.lnkUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkUser.UseSelectable = true;
            this.lnkUser.UseStyleColors = true;
            // 
            // frmUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 550);
            this.ControlBox = false;
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.lnkDeleteUser);
            this.Controls.Add(this.lnkAddUser);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lnkBack);
            this.Movable = false;
            this.Name = "frmUserMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroLink lnkBack;
        internal MetroFramework.Controls.MetroTextBox tbSearch;
        internal MetroFramework.Controls.MetroLink lnkAddUser;
        internal MetroFramework.Controls.MetroLink lnkDeleteUser;
        internal MetroFramework.Controls.MetroGrid gridUser;
        internal MetroFramework.Controls.MetroLink lnkRefresh;
        internal MetroFramework.Controls.MetroLink lnkLogout;
        internal MetroFramework.Controls.MetroLink lnkUser;
    }
}