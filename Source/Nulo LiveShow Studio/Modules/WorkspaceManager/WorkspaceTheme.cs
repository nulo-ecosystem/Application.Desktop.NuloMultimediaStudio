using Nulo.Modules.DockPanelSuite.Docking;
using Nulo.Modules.DockPanelSuite.WorkspaceManager;

namespace Nulo.Modules.WorkspaceManager {

    public class WorkspaceTheme : IWorkspaceTheme {

        public ThemeBase GetTheme(string key = null) {
            if(Properties.Settings.Default.Theme.Equals(key)) { return null; }
            key ??= Properties.Settings.Default.Theme;

            switch(key) {
                case "light": {
                    Properties.Settings.Default.Theme = "light";
                    Properties.Settings.Default.Save();
                    return new LightTheme();
                }
                default: {
                    Properties.Settings.Default.Theme = "dark";
                    Properties.Settings.Default.Save();
                    return new DarkTheme();
                }
            }
        }
    }
}