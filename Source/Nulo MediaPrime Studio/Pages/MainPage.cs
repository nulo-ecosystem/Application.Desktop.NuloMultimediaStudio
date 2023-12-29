using Nulo.Modules.DockPanelSuite.Docking;
using System.Windows.Forms;

namespace Nulo.Pages {

    public partial class MainPage : Form {

        public MainPage() {
            InitializeComponent();
            DockPanel.Controls.Add(Program.WorkspaceManager.DockPanel);
            Program.WorkspaceManager.Style = WorkspaceManager_Style;
            Program.WorkspaceManager.DropDown = ToolStripWorkspaces;
            Program.WorkspaceManager.Init();
        }
        private void MainPage_FormClosing(object sender, FormClosingEventArgs e) {
            Program.WorkspaceManager.Dispose();
        }

        private void WorkspaceManager_Style(ToolStripExtender style) {
            BackColor = Program.WorkspaceManager.Theme.ColorPalette.CommandBarMenuDefault.Background;

            style.SetStyle(MenuStrip);
            style.SetStyle(ToolStrip);
            style.SetStyle(StatusStrip);
        }
    }
}