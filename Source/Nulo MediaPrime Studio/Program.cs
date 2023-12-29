using Nulo.Modules.DockPanelSuite.WorkspaceManager;
using Nulo.Modules.WorkspaceManager;
using System;
using System.Windows.Forms;

namespace Nulo {

    internal static class Program {

        public static WorkspaceManager<WorkspaceTheme, WorkspaceData> WorkspaceManager;

        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();

            WorkspaceManager = new WorkspaceManager<WorkspaceTheme, WorkspaceData>();

            Application.Run(new Pages.MainPage());
        }
    }
}