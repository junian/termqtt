using System;
namespace Juniansoft.Termqtt.Core.Services
{
    public interface INotificationService
    {
        void Show(string title, string message);
    }
}
