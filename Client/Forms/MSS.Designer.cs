namespace Client.Forms
{
    partial class MSS
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Host IP");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Port");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Fav");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSS));
            this.TemaVS2012Dark = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.leftPanel = new Telerik.WinControls.UI.RadPanel();
            this.addressList = new Telerik.WinControls.UI.RadListView();
            this.addressPanelManager = new Telerik.WinControls.UI.RadPanel();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.valFavorite = new Telerik.WinControls.UI.RadCheckBox();
            this.lblFavorite = new Telerik.WinControls.UI.RadLabel();
            this.valHostPort = new Telerik.WinControls.UI.RadTextBox();
            this.lblHostPort = new Telerik.WinControls.UI.RadLabel();
            this.valHostIP = new Telerik.WinControls.UI.RadTextBox();
            this.lblHostIP = new Telerik.WinControls.UI.RadLabel();
            this.rightPanel = new Telerik.WinControls.UI.RadPanel();
            this.centerPanel = new Telerik.WinControls.UI.RadPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanel)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPanelManager)).BeginInit();
            this.addressPanelManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHostPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHostIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPanel)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerPanel)).BeginInit();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.addressList);
            this.leftPanel.Controls.Add(this.addressPanelManager);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(228, 570);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.leftPanel.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // addressList
            // 
            this.addressList.AllowColumnReorder = false;
            this.addressList.AllowColumnResize = false;
            this.addressList.AllowEdit = false;
            this.addressList.AllowRemove = false;
            listViewDetailColumn1.HeaderText = "Host IP";
            listViewDetailColumn2.HeaderText = "Port";
            listViewDetailColumn2.MinWidth = 40F;
            listViewDetailColumn2.Width = 60F;
            listViewDetailColumn3.HeaderText = "Fav";
            listViewDetailColumn3.MaxWidth = 40F;
            listViewDetailColumn3.Width = 40F;
            this.addressList.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.addressList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressList.EnableColumnSort = true;
            this.addressList.EnableFiltering = true;
            this.addressList.EnableSorting = true;
            this.addressList.Location = new System.Drawing.Point(0, 0);
            this.addressList.Name = "addressList";
            this.addressList.Size = new System.Drawing.Size(228, 442);
            this.addressList.TabIndex = 0;
            this.addressList.TabStop = false;
            this.addressList.ThemeName = "VisualStudio2012Dark";
            this.addressList.SelectedItemChanged += new System.EventHandler(this.addressList_SelectedItemChanged);
            // 
            // addressPanelManager
            // 
            this.addressPanelManager.Controls.Add(this.btnDelete);
            this.addressPanelManager.Controls.Add(this.btnSave);
            this.addressPanelManager.Controls.Add(this.btnRefresh);
            this.addressPanelManager.Controls.Add(this.valFavorite);
            this.addressPanelManager.Controls.Add(this.lblFavorite);
            this.addressPanelManager.Controls.Add(this.valHostPort);
            this.addressPanelManager.Controls.Add(this.lblHostPort);
            this.addressPanelManager.Controls.Add(this.valHostIP);
            this.addressPanelManager.Controls.Add(this.lblHostIP);
            this.addressPanelManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addressPanelManager.Location = new System.Drawing.Point(0, 442);
            this.addressPanelManager.Name = "addressPanelManager";
            this.addressPanelManager.Size = new System.Drawing.Size(228, 128);
            this.addressPanelManager.TabIndex = 1;
            this.addressPanelManager.ThemeName = "VisualStudio2012Dark";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(137, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 24);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ThemeName = "VisualStudio2012Dark";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "VisualStudio2012Dark";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(137, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 24);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ThemeName = "VisualStudio2012Dark";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // valFavorite
            // 
            this.valFavorite.Location = new System.Drawing.Point(66, 62);
            this.valFavorite.Name = "valFavorite";
            this.valFavorite.Size = new System.Drawing.Size(18, 18);
            this.valFavorite.TabIndex = 4;
            this.valFavorite.ThemeName = "VisualStudio2012Dark";
            // 
            // lblFavorite
            // 
            this.lblFavorite.Location = new System.Drawing.Point(4, 62);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(46, 18);
            this.lblFavorite.TabIndex = 6;
            this.lblFavorite.Text = "Favorite";
            this.lblFavorite.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.lblFavorite.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // valHostPort
            // 
            this.valHostPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valHostPort.Location = new System.Drawing.Point(94, 34);
            this.valHostPort.Name = "valHostPort";
            this.valHostPort.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valHostPort.Size = new System.Drawing.Size(128, 20);
            this.valHostPort.TabIndex = 3;
            this.valHostPort.ThemeName = "VisualStudio2012Dark";
            // 
            // lblHostPort
            // 
            this.lblHostPort.Location = new System.Drawing.Point(4, 34);
            this.lblHostPort.Name = "lblHostPort";
            this.lblHostPort.Size = new System.Drawing.Size(53, 18);
            this.lblHostPort.TabIndex = 1;
            this.lblHostPort.Text = "Host Port";
            this.lblHostPort.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.lblHostPort.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // valHostIP
            // 
            this.valHostIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valHostIP.Location = new System.Drawing.Point(94, 6);
            this.valHostIP.Name = "valHostIP";
            this.valHostIP.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valHostIP.Size = new System.Drawing.Size(128, 20);
            this.valHostIP.TabIndex = 2;
            this.valHostIP.ThemeName = "VisualStudio2012Dark";
            // 
            // lblHostIP
            // 
            this.lblHostIP.Location = new System.Drawing.Point(4, 9);
            this.lblHostIP.Name = "lblHostIP";
            this.lblHostIP.Size = new System.Drawing.Size(42, 18);
            this.lblHostIP.TabIndex = 0;
            this.lblHostIP.Text = "Host IP";
            this.lblHostIP.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.lblHostIP.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.radGroupBox3);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(592, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 570);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.TabStop = false;
            this.rightPanel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.rightPanel.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.radPanel2);
            this.centerPanel.Controls.Add(this.radPanel1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(228, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.centerPanel.Size = new System.Drawing.Size(364, 570);
            this.centerPanel.TabIndex = 2;
            this.centerPanel.TabStop = false;
            this.centerPanel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadPanelElement)(this.centerPanel.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.centerPanel.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "Server Info";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(171, 124);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Server Info";
            this.radGroupBox1.ThemeName = "VisualStudio2012Dark";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radGroupBox1);
            this.radPanel1.Controls.Add(this.radGroupBox2);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(4, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(360, 124);
            this.radPanel1.TabIndex = 2;
            this.radPanel1.TabStop = false;
            this.radPanel1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radPanel2
            // 
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel2.Location = new System.Drawing.Point(4, 124);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(360, 339);
            this.radPanel2.TabIndex = 3;
            this.radPanel2.TabStop = false;
            this.radPanel2.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.radGroupBox2.HeaderText = "Minecraft Info";
            this.radGroupBox2.Location = new System.Drawing.Point(171, 0);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(189, 124);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Minecraft Info";
            this.radGroupBox2.ThemeName = "VisualStudio2012Dark";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox3.HeaderText = "Player List";
            this.radGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(200, 570);
            this.radGroupBox3.TabIndex = 2;
            this.radGroupBox3.Text = "Player List";
            this.radGroupBox3.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(7, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(77, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Game version:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(7, 46);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(67, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Gamemode:";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radLabel2.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(7, 70);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(44, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Players:";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radLabel3.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(7, 94);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(62, 18);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "Map name:";
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radLabel4.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            // 
            // MSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MSS";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MSS - Minecraft Server Status";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.leftPanel)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addressList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPanelManager)).EndInit();
            this.addressPanelManager.ResumeLayout(false);
            this.addressPanelManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHostPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHostIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPanel)).EndInit();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerPanel)).EndInit();
            this.centerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme TemaVS2012Dark;
        private Telerik.WinControls.UI.RadPanel leftPanel;
        private Telerik.WinControls.UI.RadPanel rightPanel;
        private Telerik.WinControls.UI.RadPanel centerPanel;
        private Telerik.WinControls.UI.RadListView addressList;
        private Telerik.WinControls.UI.RadPanel addressPanelManager;
        private Telerik.WinControls.UI.RadTextBox valHostPort;
        private Telerik.WinControls.UI.RadLabel lblHostPort;
        private Telerik.WinControls.UI.RadTextBox valHostIP;
        private Telerik.WinControls.UI.RadLabel lblHostIP;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadCheckBox valFavorite;
        private Telerik.WinControls.UI.RadLabel lblFavorite;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
