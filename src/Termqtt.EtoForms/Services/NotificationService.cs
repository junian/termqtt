using System;
using Eto.Forms;
using Juniansoft.Termqtt.Core.Services;

namespace Juniansoft.Termqtt.EtoForms.Services
{
    public class NotificationService: INotificationService
    {
        public void Show(string title, string message)
        {
            var notification = new Notification
            {
                ID = Guid.NewGuid().ToString(),
                Title = title,
                Message = message
            };

            notification.Show(MainApplication.TrayIndicator);
        }
    }
}
