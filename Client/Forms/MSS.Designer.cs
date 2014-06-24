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
            this.rightPanel = new Telerik.WinControls.UI.RadPanel();
            this.centerPanel = new Telerik.WinControls.UI.RadPanel();
            this.lblHostIP = new Telerik.WinControls.UI.RadLabel();
            this.lblHostPort = new Telerik.WinControls.UI.RadLabel();
            this.valHostIP = new Telerik.WinControls.UI.RadTextBox();
            this.valHostPort = new Telerik.WinControls.UI.RadTextBox();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.lblFavorite = new Telerik.WinControls.UI.RadLabel();
            this.valFavorite = new Telerik.WinControls.UI.RadCheckBox();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanel)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPanelManager)).BeginInit();
            this.addressPanelManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHostIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHostPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
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
            // rightPanel
            // 
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
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(228, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.centerPanel.Size = new System.Drawing.Size(364, 570);
            this.centerPanel.TabIndex = 2;
            this.centerPanel.TabStop = false;
            this.centerPanel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadPanelElement)(this.centerPanel.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.centerPanel.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // lblHostIP
            // 
            this.lblHostIP.Location = new System.Drawing.Point(4, 9);
            this.lblHostIP.Name = "lblHostIP";
            this.lblHostIP.Size = new System.Drawing.Size(42, 18);
            this.lblHostIP.TabIndex = 0;
            this.lblHostIP.Text = "Host IP";
            this.lblHostIP.ThemeName = "VisualStudio2012Dark";
            // 
            // lblHostPort
            // 
            this.lblHostPort.Location = new System.Drawing.Point(4, 34);
            this.lblHostPort.Name = "lblHostPort";
            this.lblHostPort.Size = new System.Drawing.Size(53, 18);
            this.lblHostPort.TabIndex = 1;
            this.lblHostPort.Text = "Host Port";
            this.lblHostPort.ThemeName = "VisualStudio2012Dark";
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
            // lblFavorite
            // 
            this.lblFavorite.Location = new System.Drawing.Point(4, 62);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(46, 18);
            this.lblFavorite.TabIndex = 6;
            this.lblFavorite.Text = "Favorite";
            this.lblFavorite.ThemeName = "VisualStudio2012Dark";
            // 
            // valFavorite
            // 
            this.valFavorite.Location = new System.Drawing.Point(66, 62);
            this.valFavorite.Name = "valFavorite";
            this.valFavorite.Size = new System.Drawing.Size(18, 18);
            this.valFavorite.TabIndex = 4;
            this.valFavorite.ThemeName = "VisualStudio2012Dark";
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
            ((System.ComponentModel.ISupportInitialize)(this.rightPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHostIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHostPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
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
    }
}
