using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPFinsGateway_Omron
{
    static class Global
    {
        private static PLC _Plcobj;
        public static PLC Plcobj
        {
            get => _Plcobj;
            set => _Plcobj = value;
        }

        public static Settings _settings;
        public static Settings settings
        {
            get => _settings;
            set => _settings = value;
        }
    }
}
