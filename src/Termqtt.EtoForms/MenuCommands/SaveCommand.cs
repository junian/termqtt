﻿using Eto;
using Eto.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juniansoft.Termqtt.EtoForms.Resources;

namespace Juniansoft.Termqtt.EtoForms.MenuCommands
{
    public class SaveCommand: Command
    {
        public SaveCommand()
        {
            this.MenuText = "&Save";
            if (!Platform.Instance.IsWinForms)
                this.ToolBarText = "Save";
            this.ToolTip = "Save";
            this.Image = DesktopAppResources.DocumentSave;
            this.Shortcut = Application.Instance.CommonModifier | Keys.S;
        }
    }
}
