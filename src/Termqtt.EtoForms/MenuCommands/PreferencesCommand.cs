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
    public class PreferencesCommand: Command
    {
        public PreferencesCommand()
        {
            this.MenuText = "Preferences...";
            if (!Platform.Instance.IsWinForms)
                this.ToolBarText = "Preferences";
            this.ToolTip = "Preferences";
            if (Platform.Instance.IsMac)
                this.Shortcut = Application.Instance.CommonModifier | Keys.Comma;
            this.Image = DesktopAppResources.Preferences;
        }
    }
}
