using System;
using Juniansoft.Termqtt.Core.Events;

namespace Juniansoft.Termqtt.Core.ViewModels
{
    public class CoreViewModel: BaseViewModel
    {
        public event EventHandler<LogReceivedEventArgs> LogReceived;

        protected void OnLogReceived(object message, string logLevel = "INFO")
        {
            LogReceived?.Invoke(this, new LogReceivedEventArgs(message?.ToString(), logLevel));
        }
    }
}
