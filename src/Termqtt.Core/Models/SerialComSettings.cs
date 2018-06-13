using System;
namespace Juniansoft.Termqtt.Core.Models
{
    public class SerialComSettings
    {
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public int Handshake { get; set; }
        public int Parity { get; set; }
        public int DataBits { get; set; }
        public int StopBits { get; set; }
        public bool IsDtrEnable { get; set; }
        public bool IsRtsEnable { get; set; }
    }
}
