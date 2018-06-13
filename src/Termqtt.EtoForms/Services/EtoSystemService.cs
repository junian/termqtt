using System;
using Eto.Forms;

namespace Juniansoft.Termqtt.EtoForms.Services
{
    public class EtoSystemService: Juniansoft.Termqtt.Core.Services.SystemService
    {
        public EtoSystemService()
        {
        }

        public override void Quit()
        {
            Application.Instance.Quit();
        }
    }
}
