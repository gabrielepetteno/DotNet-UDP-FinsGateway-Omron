using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Net.Sockets;
using System.Threading;

namespace UDPFinsGateway_Omron
{
    public partial class Home1 : MaterialSkin.Controls.MaterialForm
    {

        //Theme
        public MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public Home1()
        {
            InitializeComponent();

            Global.Plcobj = new PLC();
            Global.settings = new Settings();
            Global.settings.THEME = MaterialSkinManager.Themes.DARK;
            Global.settings.Save();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Global.settings.THEME;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        

        private void Salva_Impostazioni_Click(object sender, EventArgs e)
        {
            Global.settings.RemoteIPAddress = Input_IP_PLC.Text;
            Global.settings.RemoteIPPort = Input_Port_PLC.Text;
            Global.settings.SourceIPAddress = Input_IP_PC.Text;
            Global.settings.SourceIPPort = Input_Port_PC.Text;

            Global.settings.ICF = Input_ICF.Text;
            Global.settings.RSV = Input_RSV.Text;
            Global.settings.GCT = Input_GCT.Text;
            Global.settings.DNA = Input_DNA.Text;
            Global.settings.DA1 = Input_DA1.Text;
            Global.settings.DA2 = Input_DA2.Text;
            Global.settings.SNA = Input_SNA.Text;
            Global.settings.SA1 = Input_SA1.Text;
            Global.settings.SA2 = Input_SA2.Text;

            Global.settings.THEME = materialSkinManager.Theme;
            Global.settings.Save();
        }

        private void Reset_Impostazioni_Click(object sender, EventArgs e)
        {
            Input_IP_PC.Text = Global.settings.SourceIPAddress;
            Input_Port_PC.Text = Global.settings.SourceIPPort.ToString();
            Input_IP_PLC.Text = Global.settings.RemoteIPAddress;
            Input_Port_PLC.Text = Global.settings.RemoteIPPort.ToString();

            Input_ICF.Text = Global.settings.ICF;
            Input_RSV.Text = Global.settings.RSV;
            Input_GCT.Text = Global.settings.GCT;
            Input_DNA.Text = Global.settings.DNA;
            Input_DA1.Text = Global.settings.DA1;
            Input_DA2.Text = Global.settings.DA2;
            Input_SNA.Text = Global.settings.SNA;
            Input_SA1.Text = Global.settings.SA1;
            Input_SA2.Text = Global.settings.SA2;
        }


        private void Tema_Dark_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void Tema_Light_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void PLCPingButton_Click(object sender, EventArgs ev)
        {
            try
            {
                Console.WriteLine(Global.Plcobj.PLC_Ping(Input_IP_PLC.Text), "Ping", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, "Ping", MessageBoxButtons.OK);
            }
        }

        private void PcGetIPButton_Click(object sender, EventArgs e)
        {
            Input_IP_PC.Text = GetLocalIpAddress();
        }
        
        public static string GetLocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static string ToHex(byte[] bytes)
        {
            char[] c = new char[bytes.Length * 2];

            byte b;

            for (int bx = 0, cx = 0; bx < bytes.Length; ++bx, ++cx)
            {
                b = ((byte)(bytes[bx] >> 4));
                c[cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);

                b = ((byte)(bytes[bx] & 0x0F));
                c[++cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);
            }

            return new string(c);
        }

        public static byte[] HexToBytes(string str)
        {
            if (str.Length == 0 || str.Length % 2 != 0)
                return new byte[0];

            byte[] buffer = new byte[str.Length / 2];
            char c;
            for (int bx = 0, sx = 0; bx < buffer.Length; ++bx, ++sx)
            {
                // Convert first half of byte
                c = str[sx];
                buffer[bx] = (byte)((c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0')) << 4);

                // Convert second half of byte
                c = str[++sx];
                buffer[bx] |= (byte)(c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0'));
            }

            return buffer;
        }


        /// <summary>
        /// Write DM
        /// </summary>
        private void Write_Button_Click(object sender, EventArgs e)
        {
            Global.Plcobj.WriteDM(Global.settings.SourceIPAddress, Convert.ToInt16(Global.settings.SourceIPPort), Global.settings.RemoteIPAddress, Convert.ToInt16(Global.settings.RemoteIPPort), Convert.ToInt32(Write_DM.Text), Convert.ToInt32(Write_Value.Text));
        }

        /// <summary>
        /// Read DM
        /// </summary>
        private void Read_Button_Click(object sender, EventArgs e)
        {
            Read_Result.Text = String.Join(" - ", Global.Plcobj.ReadDM(Global.settings.SourceIPAddress, Convert.ToInt16(Global.settings.SourceIPPort), Global.settings.RemoteIPAddress, Convert.ToInt16(Global.settings.RemoteIPPort), Convert.ToInt32(Read_DM.Text), Convert.ToInt32(Read_Num.Text)));
        }
    }
}
