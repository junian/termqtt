using Eto.Forms;
using Juniansoft.Termqtt.Core.ViewModels;
using Juniansoft.Termqtt.EtoForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juniansoft.MvvmReady;

namespace Juniansoft.Termqtt.EtoForms.Forms
{
    public class PreferencesForm : Dialog
    {
        public PreferencesForm()
        {
            var vm = ServiceLocator.Current.Get<PreferencesViewModel>();
            var view = ServiceLocator.Current.Get<PreferencesView>();

            this.Content = view;
            this.Title = "Preferences";
            this.DataContext = vm;
        }
    }
}
