namespace StabilityQualityControlSystemUI.Forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileProduct = new MetroFramework.Controls.MetroTile();
            this.tileChamber = new MetroFramework.Controls.MetroTile();
            this.tileCountry = new MetroFramework.Controls.MetroTile();
            this.tileBatch = new MetroFramework.Controls.MetroTile();
            this.tileStabilityCheck = new MetroFramework.Controls.MetroTile();
            this.tileStabilityTestReport = new MetroFramework.Controls.MetroTile();
            this.tileUser = new MetroFramework.Controls.MetroTile();
            this.lnkUser = new MetroFramework.Controls.MetroLink();
            this.lnkLogout = new MetroFramework.Controls.MetroLink();
            this.tileReport = new MetroFramework.Controls.MetroTile();
            this.tileTestMaster = new MetroFramework.Controls.MetroTile();
            this.tileDueList = new MetroFramework.Controls.MetroTile();
            this.gridDueList = new MetroFramework.Controls.MetroGrid();
            this.ddlperiod = new MetroFramework.Controls.MetroComboBox();
            this.tileDueList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDueList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lblName.Location = new System.Drawing.Point(83, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(824, 65);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "SIGMA LABORATORIES LIMITED, GOA";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(94, 142);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(261, 25);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Stability Quality Control System";
            this.metroLabel1.UseStyleColors = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(100, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 10);
            this.panel1.TabIndex = 43;
            // 
            // tileProduct
            // 
            this.tileProduct.ActiveControl = null;
            this.tileProduct.Location = new System.Drawing.Point(561, 441);
            this.tileProduct.Name = "tileProduct";
            this.tileProduct.Size = new System.Drawing.Size(246, 120);
            this.tileProduct.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileProduct.TabIndex = 35;
            this.tileProduct.Text = "&Product Master";
            this.tileProduct.TileImage = ((System.Drawing.Image)(resources.GetObject("tileProduct.TileImage")));
            this.tileProduct.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileProduct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileProduct.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileProduct.UseSelectable = true;
            this.tileProduct.UseTileImage = true;
            this.tileProduct.Click += new System.EventHandler(this.tileProduct_Click);
            // 
            // tileChamber
            // 
            this.tileChamber.ActiveControl = null;
            this.tileChamber.Location = new System.Drawing.Point(561, 189);
            this.tileChamber.Name = "tileChamber";
            this.tileChamber.Size = new System.Drawing.Size(246, 120);
            this.tileChamber.Style = MetroFramework.MetroColorStyle.Green;
            this.tileChamber.TabIndex = 44;
            this.tileChamber.Text = "&Chamber Master";
            this.tileChamber.TileImage = ((System.Drawing.Image)(resources.GetObject("tileChamber.TileImage")));
            this.tileChamber.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileChamber.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileChamber.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileChamber.UseSelectable = true;
            this.tileChamber.UseTileImage = true;
            this.tileChamber.Click += new System.EventHandler(this.tileChamber_Click);
            // 
            // tileCountry
            // 
            this.tileCountry.ActiveControl = null;
            this.tileCountry.Location = new System.Drawing.Point(561, 315);
            this.tileCountry.Name = "tileCountry";
            this.tileCountry.Size = new System.Drawing.Size(120, 120);
            this.tileCountry.Style = MetroFramework.MetroColorStyle.Brown;
            this.tileCountry.TabIndex = 45;
            this.tileCountry.Text = "Country \r\nMaster";
            this.tileCountry.TileImage = ((System.Drawing.Image)(resources.GetObject("tileCountry.TileImage")));
            this.tileCountry.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCountry.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCountry.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCountry.UseSelectable = true;
            this.tileCountry.UseTileImage = true;
            this.tileCountry.Click += new System.EventHandler(this.tileCountry_Click);
            // 
            // tileBatch
            // 
            this.tileBatch.ActiveControl = null;
            this.tileBatch.Location = new System.Drawing.Point(309, 441);
            this.tileBatch.Name = "tileBatch";
            this.tileBatch.Size = new System.Drawing.Size(246, 120);
            this.tileBatch.TabIndex = 46;
            this.tileBatch.Text = "Manage &Batch";
            this.tileBatch.TileImage = ((System.Drawing.Image)(resources.GetObject("tileBatch.TileImage")));
            this.tileBatch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileBatch.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileBatch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileBatch.UseSelectable = true;
            this.tileBatch.UseTileImage = true;
            this.tileBatch.Click += new System.EventHandler(this.tileBatch_Click);
            // 
            // tileStabilityCheck
            // 
            this.tileStabilityCheck.ActiveControl = null;
            this.tileStabilityCheck.Location = new System.Drawing.Point(309, 189);
            this.tileStabilityCheck.Name = "tileStabilityCheck";
            this.tileStabilityCheck.Size = new System.Drawing.Size(246, 246);
            this.tileStabilityCheck.Style = MetroFramework.MetroColorStyle.Lime;
            this.tileStabilityCheck.TabIndex = 48;
            this.tileStabilityCheck.Text = "Manage &Stability Check";
            this.tileStabilityCheck.TileImage = ((System.Drawing.Image)(resources.GetObject("tileStabilityCheck.TileImage")));
            this.tileStabilityCheck.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileStabilityCheck.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileStabilityCheck.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileStabilityCheck.UseSelectable = true;
            this.tileStabilityCheck.UseTileImage = true;
            this.tileStabilityCheck.Click += new System.EventHandler(this.tileStabilityCheck_Click);
            // 
            // tileStabilityTestReport
            // 
            this.tileStabilityTestReport.ActiveControl = null;
            this.tileStabilityTestReport.Location = new System.Drawing.Point(100, 189);
            this.tileStabilityTestReport.Name = "tileStabilityTestReport";
            this.tileStabilityTestReport.Size = new System.Drawing.Size(203, 372);
            this.tileStabilityTestReport.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileStabilityTestReport.TabIndex = 49;
            this.tileStabilityTestReport.Text = "Stability Planner \r\n&& Test Report";
            this.tileStabilityTestReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileStabilityTestReport.TileImage = ((System.Drawing.Image)(resources.GetObject("tileStabilityTestReport.TileImage")));
            this.tileStabilityTestReport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileStabilityTestReport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileStabilityTestReport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileStabilityTestReport.UseSelectable = true;
            this.tileStabilityTestReport.UseTileImage = true;
            this.tileStabilityTestReport.Click += new System.EventHandler(this.tileStabilityTestReport_Click);
            // 
            // tileUser
            // 
            this.tileUser.ActiveControl = null;
            this.tileUser.Location = new System.Drawing.Point(814, 189);
            this.tileUser.Name = "tileUser";
            this.tileUser.Size = new System.Drawing.Size(236, 246);
            this.tileUser.Style = MetroFramework.MetroColorStyle.Red;
            this.tileUser.TabIndex = 51;
            this.tileUser.Text = "Manage &User";
            this.tileUser.TileImage = ((System.Drawing.Image)(resources.GetObject("tileUser.TileImage")));
            this.tileUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileUser.UseSelectable = true;
            this.tileUser.UseTileImage = true;
            this.tileUser.Click += new System.EventHandler(this.tileUser_Click);
            // 
            // lnkUser
            // 
            this.lnkUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkUser.AutoSize = true;
            this.lnkUser.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkUser.Image = ((System.Drawing.Image)(resources.GetObject("lnkUser.Image")));
            this.lnkUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkUser.ImageSize = 32;
            this.lnkUser.Location = new System.Drawing.Point(1039, 6);
            this.lnkUser.Name = "lnkUser";
            this.lnkUser.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkUser.NoFocusImage")));
            this.lnkUser.Size = new System.Drawing.Size(40, 35);
            this.lnkUser.TabIndex = 52;
            this.lnkUser.TabStop = false;
            this.lnkUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkUser.UseSelectable = true;
            this.lnkUser.UseStyleColors = true;
            // 
            // lnkLogout
            // 
            this.lnkLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkLogout.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogout.Image")));
            this.lnkLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLogout.ImageSize = 20;
            this.lnkLogout.Location = new System.Drawing.Point(1281, 6);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkLogout.NoFocusImage")));
            this.lnkLogout.Size = new System.Drawing.Size(94, 35);
            this.lnkLogout.TabIndex = 53;
            this.lnkLogout.TabStop = false;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkLogout.UseSelectable = true;
            this.lnkLogout.UseStyleColors = true;
            this.lnkLogout.Click += new System.EventHandler(this.lnkLogout_Click);
            // 
            // tileReport
            // 
            this.tileReport.ActiveControl = null;
            this.tileReport.Location = new System.Drawing.Point(814, 442);
            this.tileReport.Name = "tileReport";
            this.tileReport.Size = new System.Drawing.Size(236, 119);
            this.tileReport.TabIndex = 54;
            this.tileReport.Text = "&Reports";
            this.tileReport.TileImage = ((System.Drawing.Image)(resources.GetObject("tileReport.TileImage")));
            this.tileReport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileReport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileReport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileReport.UseSelectable = true;
            this.tileReport.UseTileImage = true;
            this.tileReport.Click += new System.EventHandler(this.tileReport_Click);
            // 
            // tileTestMaster
            // 
            this.tileTestMaster.ActiveControl = null;
            this.tileTestMaster.Location = new System.Drawing.Point(688, 316);
            this.tileTestMaster.Name = "tileTestMaster";
            this.tileTestMaster.Size = new System.Drawing.Size(119, 119);
            this.tileTestMaster.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tileTestMaster.TabIndex = 55;
            this.tileTestMaster.Text = "&Test\r\nMaster";
            this.tileTestMaster.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTestMaster.TileImage")));
            this.tileTestMaster.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTestMaster.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileTestMaster.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileTestMaster.UseSelectable = true;
            this.tileTestMaster.UseTileImage = true;
            this.tileTestMaster.Click += new System.EventHandler(this.tileTestMaster_Click);
            // 
            // tileDueList
            // 
            this.tileDueList.ActiveControl = null;
            this.tileDueList.BackColor = System.Drawing.Color.White;
            this.tileDueList.Controls.Add(this.gridDueList);
            this.tileDueList.Controls.Add(this.ddlperiod);
            this.tileDueList.Location = new System.Drawing.Point(1057, 191);
            this.tileDueList.Name = "tileDueList";
            this.tileDueList.Size = new System.Drawing.Size(289, 370);
            this.tileDueList.Style = MetroFramework.MetroColorStyle.White;
            this.tileDueList.TabIndex = 57;
            this.tileDueList.Text = "Due List";
            this.tileDueList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileDueList.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileDueList.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.tileDueList.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileDueList.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDueList.UseCustomForeColor = true;
            this.tileDueList.UseSelectable = true;
            this.tileDueList.Click += new System.EventHandler(this.tileDueList_Click);
            // 
            // gridDueList
            // 
            this.gridDueList.AllowUserToResizeRows = false;
            this.gridDueList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDueList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDueList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDueList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDueList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDueList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDueList.EnableHeadersVisualStyles = false;
            this.gridDueList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDueList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDueList.Location = new System.Drawing.Point(21, 75);
            this.gridDueList.Name = "gridDueList";
            this.gridDueList.ReadOnly = true;
            this.gridDueList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDueList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDueList.RowHeadersVisible = false;
            this.gridDueList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDueList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDueList.Size = new System.Drawing.Size(248, 273);
            this.gridDueList.TabIndex = 1;
            this.gridDueList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDueList_CellClick);
            // 
            // ddlperiod
            // 
            this.ddlperiod.FormattingEnabled = true;
            this.ddlperiod.ItemHeight = 23;
            this.ddlperiod.Items.AddRange(new object[] {
            "Today\'s",
            "Tomorrow\'s",
            "This week"});
            this.ddlperiod.Location = new System.Drawing.Point(21, 36);
            this.ddlperiod.Name = "ddlperiod";
            this.ddlperiod.Size = new System.Drawing.Size(248, 29);
            this.ddlperiod.TabIndex = 0;
            this.ddlperiod.UseSelectable = true;
            this.ddlperiod.SelectedIndexChanged += new System.EventHandler(this.ddlperiod_SelectedIndexChanged);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(1378, 751);
            this.ControlBox = false;
            this.Controls.Add(this.tileDueList);
            this.Controls.Add(this.tileTestMaster);
            this.Controls.Add(this.tileReport);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.tileUser);
            this.Controls.Add(this.tileStabilityTestReport);
            this.Controls.Add(this.tileStabilityCheck);
            this.Controls.Add(this.tileBatch);
            this.Controls.Add(this.tileCountry);
            this.Controls.Add(this.tileChamber);
            this.Controls.Add(this.tileProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmDashboard";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.tileDueList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDueList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        internal System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile tileProduct;
        private MetroFramework.Controls.MetroTile tileChamber;
        private MetroFramework.Controls.MetroTile tileCountry;
        private MetroFramework.Controls.MetroTile tileBatch;
        private MetroFramework.Controls.MetroTile tileStabilityCheck;
        private MetroFramework.Controls.MetroTile tileStabilityTestReport;
        private MetroFramework.Controls.MetroTile tileUser;
        internal MetroFramework.Controls.MetroLink lnkUser;
        internal MetroFramework.Controls.MetroLink lnkLogout;
        private MetroFramework.Controls.MetroTile tileReport;
        private MetroFramework.Controls.MetroTile tileTestMaster;
        private MetroFramework.Controls.MetroTile tileDueList;
        private MetroFramework.Controls.MetroGrid gridDueList;
        private MetroFramework.Controls.MetroComboBox ddlperiod;
    }
}