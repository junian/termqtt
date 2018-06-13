using System;
namespace Juniansoft.Termqtt.Core.Services
{
    public interface IJsonService
    {
        string Serialize<T>(T obj, bool pretty = false);
        T Deserialize<T>(string json);
    }
}
