using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eto.Forms;
using Juniansoft.Termqtt.Core;

namespace Juniansoft.Termqtt.EtoForms.MenuCommands
{
    public class AboutCommand: Command
    {
        public AboutCommand()
        {
            this.MenuText = $"About {CoreApp.AssemblyProduct}";
            this.ToolBarText = "About";
            this.ToolTip = "About";
        }
    }
}
