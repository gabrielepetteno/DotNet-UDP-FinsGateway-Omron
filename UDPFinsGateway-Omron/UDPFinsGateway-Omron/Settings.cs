using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPFinsGateway_Omron
{
    class Settings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("192.168.1.13")]
        [SettingsDescription("Source IP Address of the PC")]
        public string SourceIPAddress
        {
            get
            {
                return ((string)this["SourceIPAddress"]);
            }
            set
            {
                this["SourceIPAddress"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("9600")]
        [SettingsDescription("Source IP Port of the PC")]
        public string SourceIPPort
        {
            get
            {
                return ((string)this["SourceIPPort"]);
            }
            set
            {
                this["SourceIPPort"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("192.168.1.10")]
        [SettingsDescription("IP Address of the PLC")]
        public string RemoteIPAddress
        {
            get
            {
                return ((string)this["RemoteIPAddress"]);
            }
            set
            {
                this["RemoteIPAddress"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("9600")]
        [SettingsDescription("Remote IP Port of the PLC")]
        public string RemoteIPPort
        {
            get
            {
                return ((string)this["RemoteIPPort"]);
            }
            set
            {
                this["RemoteIPPort"] = value; ;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("80")]
        [SettingsDescription("Display frame information: (hex)80 risp, 81 senza risp")]
        public string ICF
        {
            get
            {
                return ((string)this["ICF"]);
            }
            set
            {
                this["ICF"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("00")]
        [SettingsDescription("Reserved by system: (hex)00")]
        public string RSV
        {
            get
            {
                return ((string)this["RSV"]);
            }
            set
            {
                this["RSV"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("02")]
        [SettingsDescription("Permissible number of gateways: (hex)02")]
        public string GCT
        {
            get
            {
                return ((string)this["GCT"]);
            }
            set
            {
                this["GCT"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("00")]
        [SettingsDescription("Permissible number of gateways: Destination network address: (hex)00, local network")]
        public string DNA
        {
            get
            {
                return ((string)this["DNA"]);
            }
            set
            {
                this["DNA"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0A")]
        [SettingsDescription("Destination node address: (hex)00 local PLC unit, 0A = 10 -> 192.168.1.10 (IP PLC)")]
        public string DA1
        {
            get
            {
                return ((string)this["DA1"]);
            }
            set
            {
                this["DA1"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("00")]
        [SettingsDescription("Destination unit address: (hex)00, PLC")]
        public string DA2
        {
            get
            {
                return ((string)this["DA2"]);
            }
            set
            {
                this["DA2"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("00")]
        [SettingsDescription("Source network address: (hex)00, local network")]
        public string SNA
        {
            get
            {
                return ((string)this["SNA"]);
            }
            set
            {
                this["SNA"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0D")]
        [SettingsDescription("Source node address: (hex)00 = local PLC unit, 0D = 13 -> 192.168.1.13 (IP PC)")]
        public string SA1
        {
            get
            {
                return ((string)this["SA1"]);
            }
            set
            {
                this["SA1"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("00")]
        [SettingsDescription("Source unit address: (hex)00 = PC only has one ethernet")]
        public string SA2
        {
            get
            {
                return ((string)this["SA2"]);
            }
            set
            {
                this["SA2"] = (string)value;
            }
        }

        [UserScopedSetting()]
        public MaterialSkinManager.Themes THEME
        {
            get
            {
                return ((MaterialSkinManager.Themes)this["THEME"]);
            }
            set
            {
                this["THEME"] = (MaterialSkinManager.Themes)value;
            }
        }
    }
}