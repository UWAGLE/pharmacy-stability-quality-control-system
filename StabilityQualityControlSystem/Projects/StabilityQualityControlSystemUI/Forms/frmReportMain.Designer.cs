namespace StabilityQualityControlSystemUI.Forms
{
    partial class frmReportMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportMain));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lnkLogout = new MetroFramework.Controls.MetroLink();
            this.lnkUser = new MetroFramework.Controls.MetroLink();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.txtToDate = new MetroFramework.Controls.MetroDateTime();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtFromDate = new MetroFramework.Controls.MetroDateTime();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.rvMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
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
            // lnkBack
            // 
            this.lnkBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkBack.Image = ((System.Drawing.Image)(resources.GetObject("lnkBack.Image")));
            this.lnkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkBack.ImageSize = 32;
            this.lnkBack.Location = new System.Drawing.Point(3, 8);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(120, 35);
            this.lnkBack.TabIndex = 4;
            this.lnkBack.Text = "Reports";
            this.lnkBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(451, 48);
            this.txtToDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(200, 29);
            this.txtToDate.TabIndex = 59;
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(55, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(370, 54);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel2.TabIndex = 58;
            this.htmlLabel2.Text = "To Date :";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(165, 48);
            this.txtFromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(200, 29);
            this.txtFromDate.TabIndex = 57;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(68, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(84, 54);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 56;
            this.htmlLabel1.Text = "From Date :";
            // 
            // btnLoad
            // 
            this.btnLoad.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLoad.Highlight = true;
            this.btnLoad.Location = new System.Drawing.Point(683, 48);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 29);
            this.btnLoad.TabIndex = 60;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // rvMain
            // 
            reportDataSource1.Name = "DataSet1";
            this.rvMain.LocalReport.DataSources.Add(reportDataSource1);
            this.rvMain.LocalReport.ReportEmbeddedResource = "StabilityQualityControlSystemUI.Reports.rptStabilitySamplesMonthlyPlanner.rdlc";
            this.rvMain.Location = new System.Drawing.Point(84, 117);
            this.rvMain.Name = "rvMain";
            this.rvMain.Size = new System.Drawing.Size(1236, 560);
            this.rvMain.TabIndex = 61;
            this.rvMain.Load += new System.EventHandler(this.rvMain_Load);
            // 
            // frmReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 712);
            this.ControlBox = false;
            this.Controls.Add(this.rvMain);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.lnkBack);
            this.Movable = false;
            this.Name = "frmReportMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCountry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroLink lnkBack;
        internal MetroFramework.Controls.MetroLink lnkLogout;
        internal MetroFramework.Controls.MetroLink lnkUser;
        private MetroFramework.Controls.MetroDateTime txtToDate;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroDateTime txtFromDate;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton btnLoad;
        private Microsoft.Reporting.WinForms.ReportViewer rvMain;
    }
}