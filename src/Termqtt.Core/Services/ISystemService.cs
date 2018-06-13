using System;
using System.Collections.Generic;

namespace Juniansoft.Termqtt.Core.Services
{
    public interface ISystemService
    {
        IList<string> GetAvailableNetworks();
        void Quit();
    }
}
