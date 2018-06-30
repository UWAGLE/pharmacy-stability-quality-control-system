namespace StabilityQualityControlSystemUI.Forms
{
    partial class frmTestReportMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestReportMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.lnkAddTestReport = new MetroFramework.Controls.MetroLink();
            this.lnkDeleteTestReport = new MetroFramework.Controls.MetroLink();
            this.gridTestReport = new MetroFramework.Controls.MetroGrid();
            this.lnkRefresh = new MetroFramework.Controls.MetroLink();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtFromDate = new MetroFramework.Controls.MetroDateTime();
            this.txtToDate = new MetroFramework.Controls.MetroDateTime();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.gridStabilityPlanner = new MetroFramework.Controls.MetroGrid();
            this.lnkLogout = new MetroFramework.Controls.MetroLink();
            this.lnkUser = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStabilityPlanner)).BeginInit();
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
            this.lnkBack.Size = new System.Drawing.Size(229, 35);
            this.lnkBack.TabIndex = 0;
            this.lnkBack.Text = "Manage TestReports";
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
            this.tbSearch.Location = new System.Drawing.Point(111, 316);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PromptText = "Search TestReport";
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.ShowClearButton = true;
            this.tbSearch.Size = new System.Drawing.Size(234, 26);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMark = "Search TestReport";
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lnkAddTestReport
            // 
            this.lnkAddTestReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkAddTestReport.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkAddTestReport.Image = ((System.Drawing.Image)(resources.GetObject("lnkAddTestReport.Image")));
            this.lnkAddTestReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAddTestReport.ImageSize = 30;
            this.lnkAddTestReport.Location = new System.Drawing.Point(428, 302);
            this.lnkAddTestReport.Name = "lnkAddTestReport";
            this.lnkAddTestReport.Size = new System.Drawing.Size(141, 40);
            this.lnkAddTestReport.TabIndex = 4;
            this.lnkAddTestReport.Text = "Add TestReport";
            this.lnkAddTestReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkAddTestReport.UseSelectable = true;
            this.lnkAddTestReport.Click += new System.EventHandler(this.lnkAddTestReport_Click);
            // 
            // lnkDeleteTestReport
            // 
            this.lnkDeleteTestReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkDeleteTestReport.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkDeleteTestReport.Image = ((System.Drawing.Image)(resources.GetObject("lnkDeleteTestReport.Image")));
            this.lnkDeleteTestReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDeleteTestReport.ImageSize = 25;
            this.lnkDeleteTestReport.Location = new System.Drawing.Point(579, 302);
            this.lnkDeleteTestReport.Name = "lnkDeleteTestReport";
            this.lnkDeleteTestReport.Size = new System.Drawing.Size(161, 40);
            this.lnkDeleteTestReport.TabIndex = 5;
            this.lnkDeleteTestReport.Text = "Delete TestReport";
            this.lnkDeleteTestReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDeleteTestReport.UseSelectable = true;
            this.lnkDeleteTestReport.Click += new System.EventHandler(this.lnkDeleteTestReport_Click);
            // 
            // gridTestReport
            // 
            this.gridTestReport.AllowUserToAddRows = false;
            this.gridTestReport.AllowUserToDeleteRows = false;
            this.gridTestReport.AllowUserToResizeRows = false;
            this.gridTestReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridTestReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridTestReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTestReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridTestReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTestReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTestReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTestReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTestReport.EnableHeadersVisualStyles = false;
            this.gridTestReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridTestReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridTestReport.Location = new System.Drawing.Point(111, 348);
            this.gridTestReport.Name = "gridTestReport";
            this.gridTestReport.ReadOnly = true;
            this.gridTestReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTestReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTestReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridTestReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTestReport.Size = new System.Drawing.Size(1200, 214);
            this.gridTestReport.TabIndex = 7;
            this.gridTestReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTestReport_CellClick);
            this.gridTestReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTestReport_CellDoubleClick);
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lnkRefresh.Image")));
            this.lnkRefresh.ImageSize = 32;
            this.lnkRefresh.Location = new System.Drawing.Point(746, 302);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(35, 35);
            this.lnkRefresh.TabIndex = 6;
            this.lnkRefresh.UseSelectable = true;
            this.lnkRefresh.Click += new System.EventHandler(this.lnkRefresh_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(68, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(111, 50);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 12;
            this.htmlLabel1.Text = "From Date :";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(192, 44);
            this.txtFromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(200, 29);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(478, 44);
            this.txtToDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(200, 29);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(55, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(397, 50);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel2.TabIndex = 14;
            this.htmlLabel2.Text = "To Date :";
            // 
            // gridStabilityPlanner
            // 
            this.gridStabilityPlanner.AllowUserToAddRows = false;
            this.gridStabilityPlanner.AllowUserToDeleteRows = false;
            this.gridStabilityPlanner.AllowUserToResizeRows = false;
            this.gridStabilityPlanner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridStabilityPlanner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridStabilityPlanner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridStabilityPlanner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridStabilityPlanner.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStabilityPlanner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridStabilityPlanner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStabilityPlanner.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridStabilityPlanner.EnableHeadersVisualStyles = false;
            this.gridStabilityPlanner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridStabilityPlanner.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridStabilityPlanner.Location = new System.Drawing.Point(111, 79);
            this.gridStabilityPlanner.Name = "gridStabilityPlanner";
            this.gridStabilityPlanner.ReadOnly = true;
            this.gridStabilityPlanner.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStabilityPlanner.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridStabilityPlanner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridStabilityPlanner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStabilityPlanner.Size = new System.Drawing.Size(1200, 217);
            this.gridStabilityPlanner.TabIndex = 3;
            this.gridStabilityPlanner.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStabilityPlanner_CellClick);
            this.gridStabilityPlanner.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStabilityPlanner_CellDoubleClick);
            this.gridStabilityPlanner.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridStabilityPlanner_DataBindingComplete);
            this.gridStabilityPlanner.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStabilityPlanner_CellClick);
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
            // frmTestReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 575);
            this.ControlBox = false;
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.gridStabilityPlanner);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.gridTestReport);
            this.Controls.Add(this.lnkDeleteTestReport);
            this.Controls.Add(this.lnkAddTestReport);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lnkBack);
            this.Movable = false;
            this.Name = "frmTestReportMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTestReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTestReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStabilityPlanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroLink lnkBack;
        internal MetroFramework.Controls.MetroTextBox tbSearch;
        internal MetroFramework.Controls.MetroLink lnkAddTestReport;
        internal MetroFramework.Controls.MetroLink lnkDeleteTestReport;
        internal MetroFramework.Controls.MetroGrid gridTestReport;
        internal MetroFramework.Controls.MetroLink lnkRefresh;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroDateTime txtFromDate;
        private MetroFramework.Controls.MetroDateTime txtToDate;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        internal MetroFramework.Controls.MetroGrid gridStabilityPlanner;
        internal MetroFramework.Controls.MetroLink lnkLogout;
        internal MetroFramework.Controls.MetroLink lnkUser;
    }
}