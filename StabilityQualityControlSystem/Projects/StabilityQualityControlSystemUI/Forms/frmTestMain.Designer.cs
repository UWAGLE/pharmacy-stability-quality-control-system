namespace StabilityQualityControlSystemUI.Forms
{
    partial class frmTestMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.lnkAddTest = new MetroFramework.Controls.MetroLink();
            this.lnkDeleteTest = new MetroFramework.Controls.MetroLink();
            this.gridTest = new MetroFramework.Controls.MetroGrid();
            this.lnkRefresh = new MetroFramework.Controls.MetroLink();
            this.lnkLogout = new MetroFramework.Controls.MetroLink();
            this.lnkUser = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.gridTest)).BeginInit();
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
            this.lnkBack.Size = new System.Drawing.Size(170, 35);
            this.lnkBack.TabIndex = 0;
            this.lnkBack.Text = "Manage Tests";
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
            this.tbSearch.PromptText = "Search Test";
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.ShowClearButton = true;
            this.tbSearch.Size = new System.Drawing.Size(234, 26);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMark = "Search Test";
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // lnkAddTest
            // 
            this.lnkAddTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkAddTest.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkAddTest.Image = ((System.Drawing.Image)(resources.GetObject("lnkAddTest.Image")));
            this.lnkAddTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAddTest.ImageSize = 30;
            this.lnkAddTest.Location = new System.Drawing.Point(449, 67);
            this.lnkAddTest.Name = "lnkAddTest";
            this.lnkAddTest.Size = new System.Drawing.Size(95, 40);
            this.lnkAddTest.TabIndex = 2;
            this.lnkAddTest.Text = "Add Test";
            this.lnkAddTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkAddTest.UseSelectable = true;
            this.lnkAddTest.Click += new System.EventHandler(this.lnkAddTest_Click);
            // 
            // lnkDeleteTest
            // 
            this.lnkDeleteTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkDeleteTest.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkDeleteTest.Image = ((System.Drawing.Image)(resources.GetObject("lnkDeleteTest.Image")));
            this.lnkDeleteTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDeleteTest.ImageSize = 25;
            this.lnkDeleteTest.Location = new System.Drawing.Point(550, 67);
            this.lnkDeleteTest.Name = "lnkDeleteTest";
            this.lnkDeleteTest.Size = new System.Drawing.Size(110, 40);
            this.lnkDeleteTest.TabIndex = 3;
            this.lnkDeleteTest.Text = "Delete Test";
            this.lnkDeleteTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDeleteTest.UseSelectable = true;
            this.lnkDeleteTest.Click += new System.EventHandler(this.lnkDeleteTest_Click);
            // 
            // gridTest
            // 
            this.gridTest.AllowUserToAddRows = false;
            this.gridTest.AllowUserToDeleteRows = false;
            this.gridTest.AllowUserToResizeRows = false;
            this.gridTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTest.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTest.EnableHeadersVisualStyles = false;
            this.gridTest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridTest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridTest.Location = new System.Drawing.Point(111, 113);
            this.gridTest.Name = "gridTest";
            this.gridTest.ReadOnly = true;
            this.gridTest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTest.Size = new System.Drawing.Size(1200, 434);
            this.gridTest.TabIndex = 5;
            this.gridTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTest_CellClick);
            this.gridTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTest_CellDoubleClick);
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lnkRefresh.Image")));
            this.lnkRefresh.ImageSize = 32;
            this.lnkRefresh.Location = new System.Drawing.Point(677, 67);
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
            // frmTestMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 550);
            this.ControlBox = false;
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.gridTest);
            this.Controls.Add(this.lnkDeleteTest);
            this.Controls.Add(this.lnkAddTest);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lnkBack);
            this.Movable = false;
            this.Name = "frmTestMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroLink lnkBack;
        internal MetroFramework.Controls.MetroTextBox tbSearch;
        internal MetroFramework.Controls.MetroLink lnkAddTest;
        internal MetroFramework.Controls.MetroLink lnkDeleteTest;
        internal MetroFramework.Controls.MetroGrid gridTest;
        internal MetroFramework.Controls.MetroLink lnkRefresh;
        internal MetroFramework.Controls.MetroLink lnkLogout;
        internal MetroFramework.Controls.MetroLink lnkUser;
    }
}