namespace StabilityQualityControlSystemUI.Forms
{
    partial class frmChamberMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamberMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.lnkAddChamber = new MetroFramework.Controls.MetroLink();
            this.lnkDeleteChamber = new MetroFramework.Controls.MetroLink();
            this.gridChamber = new MetroFramework.Controls.MetroGrid();
            this.lnkRefresh = new MetroFramework.Controls.MetroLink();
            this.lnkLogout = new MetroFramework.Controls.MetroLink();
            this.lnkUser = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.gridChamber)).BeginInit();
            this.SuspendLayout();
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
            this.lnkBack.TabIndex = 0;
            this.lnkBack.Text = "Manage Chambers";
            this.lnkBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
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
            this.tbSearch.PromptText = "Search Chamber";
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.ShowClearButton = true;
            this.tbSearch.Size = new System.Drawing.Size(234, 26);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMark = "Search Chamber";
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // lnkAddChamber
            // 
            this.lnkAddChamber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkAddChamber.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkAddChamber.Image = ((System.Drawing.Image)(resources.GetObject("lnkAddChamber.Image")));
            this.lnkAddChamber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAddChamber.ImageSize = 30;
            this.lnkAddChamber.Location = new System.Drawing.Point(412, 67);
            this.lnkAddChamber.Name = "lnkAddChamber";
            this.lnkAddChamber.Size = new System.Drawing.Size(132, 40);
            this.lnkAddChamber.TabIndex = 2;
            this.lnkAddChamber.Text = "Add Chamber";
            this.lnkAddChamber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkAddChamber.UseSelectable = true;
            this.lnkAddChamber.Click += new System.EventHandler(this.lnkAddChamber_Click);
            // 
            // lnkDeleteChamber
            // 
            this.lnkDeleteChamber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkDeleteChamber.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkDeleteChamber.Image = ((System.Drawing.Image)(resources.GetObject("lnkDeleteChamber.Image")));
            this.lnkDeleteChamber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDeleteChamber.ImageSize = 25;
            this.lnkDeleteChamber.Location = new System.Drawing.Point(550, 67);
            this.lnkDeleteChamber.Name = "lnkDeleteChamber";
            this.lnkDeleteChamber.Size = new System.Drawing.Size(140, 40);
            this.lnkDeleteChamber.TabIndex = 3;
            this.lnkDeleteChamber.Text = "Delete Chamber";
            this.lnkDeleteChamber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDeleteChamber.UseSelectable = true;
            this.lnkDeleteChamber.Click += new System.EventHandler(this.lnkDeleteChamber_Click);
            // 
            // gridChamber
            // 
            this.gridChamber.AllowUserToAddRows = false;
            this.gridChamber.AllowUserToDeleteRows = false;
            this.gridChamber.AllowUserToResizeRows = false;
            this.gridChamber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridChamber.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridChamber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridChamber.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridChamber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChamber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridChamber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChamber.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridChamber.EnableHeadersVisualStyles = false;
            this.gridChamber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridChamber.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridChamber.Location = new System.Drawing.Point(111, 113);
            this.gridChamber.Name = "gridChamber";
            this.gridChamber.ReadOnly = true;
            this.gridChamber.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChamber.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridChamber.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridChamber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridChamber.Size = new System.Drawing.Size(1200, 434);
            this.gridChamber.TabIndex = 10;
            this.gridChamber.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChamber_CellClick);
            this.gridChamber.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChamber_CellDoubleClick);
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lnkRefresh.Image")));
            this.lnkRefresh.ImageSize = 32;
            this.lnkRefresh.Location = new System.Drawing.Point(704, 67);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(35, 35);
            this.lnkRefresh.TabIndex = 4;
            this.lnkRefresh.UseSelectable = true;
            this.lnkRefresh.Click += new System.EventHandler(this.lnkRefresh_Click);
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
            // frmChamberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 550);
            this.ControlBox = false;
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.gridChamber);
            this.Controls.Add(this.lnkDeleteChamber);
            this.Controls.Add(this.lnkAddChamber);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lnkBack);
            this.Movable = false;
            this.Name = "frmChamberMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChamber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChamber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroLink lnkBack;
        internal MetroFramework.Controls.MetroTextBox tbSearch;
        internal MetroFramework.Controls.MetroLink lnkAddChamber;
        internal MetroFramework.Controls.MetroLink lnkDeleteChamber;
        internal MetroFramework.Controls.MetroGrid gridChamber;
        internal MetroFramework.Controls.MetroLink lnkRefresh;
        internal MetroFramework.Controls.MetroLink lnkLogout;
        internal MetroFramework.Controls.MetroLink lnkUser;
    }
}