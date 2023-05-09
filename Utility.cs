using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace background_time
{
    public class Utility
    {
        public static bool IsRunningAsAdministrator()
        {
            // Get the current Windows identity
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            // Create a Windows principal for the identity
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            // Check if the principal belongs to the Administrators group
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
