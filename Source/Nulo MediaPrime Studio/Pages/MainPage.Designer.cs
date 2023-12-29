namespace Nulo.Pages {
    partial class MainPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            DockPanel = new System.Windows.Forms.Panel();
            MenuStrip = new System.Windows.Forms.MenuStrip();
            ToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripWorkspaces = new System.Windows.Forms.ToolStripDropDownButton();
            StatusStrip = new System.Windows.Forms.StatusStrip();
            ToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DockPanel
            // 
            DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            DockPanel.Location = new System.Drawing.Point(0, 0);
            DockPanel.Name = "DockPanel";
            DockPanel.Size = new System.Drawing.Size(1058, 664);
            DockPanel.TabIndex = 0;
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            MenuStrip.Location = new System.Drawing.Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new System.Drawing.Size(1058, 24);
            MenuStrip.TabIndex = 0;
            // 
            // ToolStrip
            // 
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ToolStripWorkspaces });
            ToolStrip.Location = new System.Drawing.Point(0, 24);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new System.Drawing.Size(1058, 33);
            ToolStrip.TabIndex = 0;
            // 
            // ToolStripWorkspaces
            // 
            ToolStripWorkspaces.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ToolStripWorkspaces.Image = (System.Drawing.Image)resources.GetObject("ToolStripWorkspaces.Image");
            ToolStripWorkspaces.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripWorkspaces.Name = "ToolStripWorkspaces";
            ToolStripWorkspaces.Size = new System.Drawing.Size(42, 28);
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            StatusStrip.Location = new System.Drawing.Point(0, 642);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new System.Drawing.Size(1058, 22);
            StatusStrip.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1058, 664);
            Controls.Add(StatusStrip);
            Controls.Add(ToolStrip);
            Controls.Add(MenuStrip);
            Controls.Add(DockPanel);
            MainMenuStrip = MenuStrip;
            MinimumSize = new System.Drawing.Size(1080, 720);
            Name = "MainPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Nulo MediaPrime Studio 2024";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += MainPage_FormClosing;
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel DockPanel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripWorkspaces;
    }
}