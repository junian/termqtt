using System;
using Eto.Forms;
using Juniansoft.Termqtt.EtoForms.Resources;

namespace Juniansoft.Termqtt.EtoForms.MenuCommands
{
    public class BotActiveCommand: CheckCommand
    {
        public BotActiveCommand()
        {
            this.MenuText = "Activate";
            this.ToolBarText = "Activate";
            this.ToolTip = "Activate";
            this.Image = DesktopAppResources.MediaRecord;
        }
    }
}
