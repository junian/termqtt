using System;
namespace Juniansoft.Termqtt.Core
{
    public interface ITermqttApp
    {
        void Run(string[] args);
        void RegisterServices();
    }
}
