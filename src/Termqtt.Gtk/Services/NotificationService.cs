using System;
using Juniansoft.Termqtt.Core.Services;

namespace Juniansoft.Termqtt.GtkSharp.Services
{
    [Obsolete("Use EtoForms NotificationService instead")]
    public class NotificationService : INotificationService
    {
        public NotificationService()
        {
        }

        public void Show(string title, string message)
        {

        }
    }
}
