using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace background_time
{
    public class DesktopTimer
    {
        public Form form;

        public DesktopTimer(Form form)
        {
            this.form = form;

            SetStartupShortcut();
        }

        private void SetStartupShortcut()
        {
            if (!Utility.IsRunningAsAdministrator()) return;

            // Get the path to the Startup folder
            string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

            // Get the path to the current executable
            string exePath = Application.ExecutablePath;

            // Create the shortcut path
            string shortcutPath = Path.Combine(startupFolderPath, "Desktop Timer" + ".lnk");

            // Check if the shortcut already exists
            if (!File.Exists(shortcutPath))
            {
                // Create a new WshShell object to manage Windows shortcuts
                var shell = new IWshRuntimeLibrary.WshShell();

                // Create a new shortcut object
                var shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);

                // Set the shortcut properties
                shortcut.TargetPath = exePath;
                shortcut.WorkingDirectory = Path.GetDirectoryName(exePath);
                shortcut.Description = "Desktop Timer - Time and Date Display";
                shortcut.IconLocation = exePath; // Use the application's icon

                // Save the shortcut
                shortcut.Save();
            }
        }
    }
}
