namespace StabilityQualityControlSystemUI.Forms
{
    partial class frmProductMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.lnkAddProduct = new MetroFramework.Controls.MetroLink();
            this.lnkDeleteProduct = new MetroFramework.Controls.MetroLink();
            this.gridProduct = new MetroFramework.Controls.MetroGrid();
            this.lnkRefresh = new MetroFramework.Controls.MetroLink();
            this.lnkLogout = new MetroFramework.Controls.MetroLink();
            this.lnkUser = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
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
            this.lnkBack.Text = "Manage Products";
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
            this.tbSearch.PromptText = "Search product";
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.ShowClearButton = true;
            this.tbSearch.Size = new System.Drawing.Size(234, 26);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMark = "Search product";
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // lnkAddProduct
            // 
            this.lnkAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkAddProduct.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("lnkAddProduct.Image")));
            this.lnkAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAddProduct.ImageSize = 30;
            this.lnkAddProduct.Location = new System.Drawing.Point(425, 67);
            this.lnkAddProduct.Name = "lnkAddProduct";
            this.lnkAddProduct.Size = new System.Drawing.Size(126, 40);
            this.lnkAddProduct.TabIndex = 2;
            this.lnkAddProduct.Text = "Add Product";
            this.lnkAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkAddProduct.UseSelectable = true;
            this.lnkAddProduct.Click += new System.EventHandler(this.lnkAddProduct_Click);
            // 
            // lnkDeleteProduct
            // 
            this.lnkDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkDeleteProduct.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("lnkDeleteProduct.Image")));
            this.lnkDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDeleteProduct.ImageSize = 25;
            this.lnkDeleteProduct.Location = new System.Drawing.Point(550, 67);
            this.lnkDeleteProduct.Name = "lnkDeleteProduct";
            this.lnkDeleteProduct.Size = new System.Drawing.Size(131, 40);
            this.lnkDeleteProduct.TabIndex = 3;
            this.lnkDeleteProduct.Text = "Delete Product";
            this.lnkDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDeleteProduct.UseSelectable = true;
            this.lnkDeleteProduct.Click += new System.EventHandler(this.lnkDeleteProduct_Click);
            // 
            // gridProduct
            // 
            this.gridProduct.AllowUserToAddRows = false;
            this.gridProduct.AllowUserToDeleteRows = false;
            this.gridProduct.AllowUserToResizeRows = false;
            this.gridProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProduct.EnableHeadersVisualStyles = false;
            this.gridProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProduct.Location = new System.Drawing.Point(111, 113);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduct.Size = new System.Drawing.Size(1200, 434);
            this.gridProduct.TabIndex = 5;
            this.gridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduct_CellClick);
            this.gridProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduct_CellDoubleClick);
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lnkRefresh.Image")));
            this.lnkRefresh.ImageSize = 32;
            this.lnkRefresh.Location = new System.Drawing.Point(687, 67);
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
            // frmProductMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 550);
            this.ControlBox = false;
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.lnkDeleteProduct);
            this.Controls.Add(this.lnkAddProduct);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lnkBack);
            this.Movable = false;
            this.Name = "frmProductMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroLink lnkBack;
        internal MetroFramework.Controls.MetroTextBox tbSearch;
        internal MetroFramework.Controls.MetroLink lnkAddProduct;
        internal MetroFramework.Controls.MetroLink lnkDeleteProduct;
        internal MetroFramework.Controls.MetroGrid gridProduct;
        internal MetroFramework.Controls.MetroLink lnkRefresh;
        internal MetroFramework.Controls.MetroLink lnkLogout;
        internal MetroFramework.Controls.MetroLink lnkUser;
    }
}