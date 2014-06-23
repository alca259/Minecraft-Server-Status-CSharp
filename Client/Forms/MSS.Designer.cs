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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSS));
            this.TemaVS2012Dark = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.leftPanel = new Telerik.WinControls.UI.RadPanel();
            this.rightPanel = new Telerik.WinControls.UI.RadPanel();
            this.centerPanel = new Telerik.WinControls.UI.RadPanel();
            this.addressList = new Telerik.WinControls.UI.RadListView();
            this.addressPanelManager = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanel)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPanelManager)).BeginInit();
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
            this.leftPanel.Size = new System.Drawing.Size(200, 570);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.leftPanel.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(592, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 570);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.rightPanel.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // centerPanel
            // 
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(200, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(392, 570);
            this.centerPanel.TabIndex = 2;
            this.centerPanel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.centerPanel.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // addressList
            // 
            this.addressList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressList.Location = new System.Drawing.Point(0, 0);
            this.addressList.Name = "addressList";
            this.addressList.Size = new System.Drawing.Size(200, 470);
            this.addressList.TabIndex = 0;
            this.addressList.Text = "radListView1";
            this.addressList.ThemeName = "VisualStudio2012Dark";
            // 
            // addressPanelManager
            // 
            this.addressPanelManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addressPanelManager.Location = new System.Drawing.Point(0, 470);
            this.addressPanelManager.Name = "addressPanelManager";
            this.addressPanelManager.Size = new System.Drawing.Size(200, 100);
            this.addressPanelManager.TabIndex = 1;
            this.addressPanelManager.ThemeName = "VisualStudio2012Dark";
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
            ((System.ComponentModel.ISupportInitialize)(this.rightPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPanelManager)).EndInit();
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
    }
}
