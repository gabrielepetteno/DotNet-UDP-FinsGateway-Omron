using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPFinsGateway_Omron
{
    class PLC
    {
        public bool DEBUGMODE = true;

        public string PLC_Ping(string ip)
        {
            Ping pingSender = new Ping();
            IPAddress Remote_IP;

            try
            {
                Remote_IP = IPAddress.Parse(ip);
            }
            catch (Exception e)
            {
                throw new Exception("Indirizzo IP PLC Invalido" + e);
            }

            PingReply reply = pingSender.Send(Remote_IP);

            if (reply.Status == IPStatus.Success)
            {
                string txt = "";
                txt += "IP:      " + reply.Address.ToString() + "\r\n";
                txt += "RTT:   " + reply.RoundtripTime + "ms \r\n";
                txt += "TTL:   " + reply.Options.Ttl + "\r\n";

                return "Ping Andato a buon fine : \r\n\r\n" + txt;
            }
            else
            {
                throw new Exception("Indirizzo IP non raggiungibile");
            }
        }

        /// <summary>
        /// Write value in DM
        /// </summary>
        /// <param name="S_ip">Source IP: Ip of the PC</param>
        /// <param name="S_port">Source Port: Port of the PC (9600)</param>
        /// <param name="D_ip">Destination IP: IP of the PLC</param>
        /// <param name="D_port">Destination Port: Port of the PLC (UDP Port default: 9600)</param>
        /// <param name="dmnum">DM Position: (DM100)</param>
        /// <param name="value">Value of the DM</param>
        /// <returns>True if there aren't error </returns>
        public bool WriteDM(string S_ip, int S_port, string D_ip, int D_port, int dmnum, int value)
        {

            int X, CmdLength, Cnt = 0, retval;
            byte[] ByteArray = new byte[17];
            byte[] myByte = new byte[1024];
            string Header, tmp1, CMND;
            IPAddress Remote_IP, Local_IP;
            IPEndPoint Remote_IPEndPoint, Local_IPEndPoint;
            EndPoint Remote_EndPoint;
            Socket Ethernet_Socket;

            Random rnd = new Random();
            string SID = rnd.Next(1, 99).ToString("00");

            string[] D_parts = D_ip.Split('.');
            int D_fin = Convert.ToInt16(D_parts[3]);

            string DA1 = D_fin.ToString("x2").ToUpper();

            if (Global.settings.DA1 != DA1)
            {
                throw new Exception("configurazione di comunicazione errata (DNA) " + Global.settings.DNA + " <> " + DA1);
            }

            string[] S_parts = S_ip.Split('.');
            int S_fin = Convert.ToInt16(S_parts[3]);

            string SA1 = S_fin.ToString("x2").ToUpper();

            if (Global.settings.SA1 != SA1)
            {
                throw new Exception("configurazione di comunicazione errata (SNA) " + Global.settings.SNA + " <> " + SA1);
            }


            Header = Global.settings.ICF + Global.settings.RSV + Global.settings.GCT + Global.settings.DNA + Global.settings.DA1 + Global.settings.DA2 + Global.settings.SNA + Global.settings.SA1 + Global.settings.SA2 + SID;

            if (DEBUGMODE)
            {
                Console.WriteLine("Header : " + Header);
            }

            string cmd_write = "0102";
            string cmd_DM = "82";
            //string cmd_startaddress = "0064";
            string cmd_byteempty = "00";
            string cmd_wordnumber = "0001";
            //string cmd_value = "0003";

            string cmd_startaddress = dmnum.ToString("x4");
            string cmd_value = value.ToString("x4");

            CMND = Header + cmd_write + cmd_DM + cmd_startaddress + cmd_byteempty + cmd_wordnumber + cmd_value;

            if (DEBUGMODE)
            {
                Console.WriteLine("CMD : " + CMND);
            }

            //'txtSend.Text = ""
            CmdLength = CMND.Length;
            ByteArray = new byte[CmdLength / 2];

            for (X = 0; X < CmdLength; X += 2)
            {
                tmp1 = CMND.Substring(X, 2);
                ByteArray[Cnt] = Convert.ToByte(tmp1, 16);
                Cnt += 1;
            }

            if (DEBUGMODE)
            {
                Console.WriteLine("txtSend : " + ToHex(ByteArray));
            }

            try
            {
                Local_IP = IPAddress.Parse(S_ip);
            }
            catch (Exception e)
            {
                throw new Exception("invalid local IP address \r\n" + e);
            }

            try
            {
                Remote_IP = IPAddress.Parse(D_ip);
            }
            catch (Exception e)
            {
                throw new Exception("invalid PLC IP address \r\n" + e);
            }

            Remote_IPEndPoint = new IPEndPoint(Remote_IP, D_port);
            Remote_EndPoint = (EndPoint)Remote_IPEndPoint;
            Local_IPEndPoint = new IPEndPoint(Local_IP, S_port);

            Ethernet_Socket = new Socket(Local_IPEndPoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp);

            if (Ethernet_Socket != null)
            {
                Ethernet_Socket.SendTo(ByteArray, Remote_EndPoint); //send FINS cmd
                Ethernet_Socket.ReceiveTimeout = 200;

                try
                {
                    retval = Ethernet_Socket.ReceiveFrom(myByte, ref Remote_EndPoint);  //recv from socket
                    return WriteDM_Received_Data(myByte, retval, SID);      //call sub to process byte array
                }
                catch (Exception e)
                {
                    throw new Exception("No response from PLC \r\n\r\n" + e);
                }
            }
            return false;
        }

        public bool WriteDM_Received_Data(Byte[] RX_Data, int RX_Count, string SID)
        {
            int x = 0, l = 0, ln = 0;
            string t = "", chex = "", tr = "", resp = "", R = "";

            byte[] vtData;
            byte[] bytearr = new byte[1024];
            string[] dstrarr = new string[1024];
            string[] ascii = new string[1024];

            vtData = RX_Data;
            ln = RX_Count;

            for (l = 1; l <= ln; l++)
            {
                bytearr[l] = (byte)(Convert.ToByte(vtData[l - 1]));
                chex = bytearr[l].ToString("X2");
                dstrarr[l] = chex;
                resp += chex;
            }

            t = "  ICF RSV GCT DNA DA1 DA2 SNA SA1 SA2 SID MRC SRC MEC SEC\r\n";
            t = t + "  " + dstrarr[1] + "    " + dstrarr[2] + "    " + dstrarr[3] + "    " + dstrarr[4] + "    " + dstrarr[5] + "    " + dstrarr[6] + "    " + dstrarr[7] + "    " + dstrarr[8] + "    " + dstrarr[9] + "   " + dstrarr[10] + "    " + dstrarr[11] + "   " + dstrarr[12] + "    " + dstrarr[13] + "    " + dstrarr[14];

            if (dstrarr[10] != SID)
            {
                Console.WriteLine("SID Errato : " + dstrarr[10] + " <> " + SID);
            }

            if (DEBUGMODE)
            {
                Console.WriteLine("RESPOSE : " + string.Join(".", dstrarr.Take(1 + ln)));
            }

            for (x = 15; x < ln; x++)
            {
                if (bytearr[x] > 31 && bytearr[x] <= 255)
                {

                    ascii[x] = bytearr[x].ToString();
                }
                else
                {
                    ascii[x] = "0";
                }
            }

            tr = "";
            string txtrecived = "";
            for (x = 15; x < ln; x += 20)
            {
                tr = dstrarr[x] + dstrarr[x + 1] + " " + dstrarr[x + 2] + dstrarr[x + 3] + " " + dstrarr[x + 4] + dstrarr[x + 5] + " " + dstrarr[x + 6] + dstrarr[x + 7] + " " + dstrarr[x + 8] + dstrarr[x + 9] + " " + dstrarr[x + 10] + dstrarr[x + 11] + " " + dstrarr[x + 12] + dstrarr[x + 13] + " " + dstrarr[x + 14] + dstrarr[x + 15] + " " + dstrarr[x + 16] + dstrarr[x + 17] + " " + dstrarr[x + 18] + dstrarr[x + 19] + " | " + ascii[x] + ascii[x + 1] + ascii[x + 2] + ascii[x + 3] + ascii[x + 4] + ascii[x + 5] + ascii[x + 6] + ascii[x + 7] + ascii[x + 8] + ascii[x + 9] + ascii[x + 10] + ascii[x + 11] + ascii[x + 12] + ascii[x + 13] + ascii[x + 14] + ascii[x + 15] + ascii[x + 16] + ascii[x + 17] + ascii[x + 18] + ascii[x + 19];
                txtrecived += tr;
            }

            if (DEBUGMODE)
            {
                Console.WriteLine("TXT RECIVED : " + txtrecived);
            }

            if (dstrarr[13] == "00" && dstrarr[14] == "00")
            {
                return true;
            }
            else
            {
                throw new Exception("Comando errato : " + txtrecived);
            }
        }

        /// <summary>
        /// Read DM's
        /// </summary>
        /// <param name="S_ip">Source IP: Ip of the PC</param>
        /// <param name="S_port">Source Port: Port of the PC (9600)</param>
        /// <param name="D_ip">Destination IP: IP of the PLC</param>
        /// <param name="D_port">Destination Port: Port of the PLC (UDP Port default: 9600)</param>
        /// <param name="dmnum">DM start reading</param>
        /// <param name="qnt">Number of DM's to Read</param>
        /// <returns>Array of values</returns>
        public int[] ReadDM(string S_ip, int S_port, string D_ip, int D_port, int dmnum, int qnt)
        {

            int X, CmdLength, Cnt = 0, retval;
            byte[] ByteArray = new byte[17];
            byte[] myByte = new byte[1024];
            string Header, tmp1, CMND;
            IPAddress Remote_IP, Local_IP;
            IPEndPoint Remote_IPEndPoint, Local_IPEndPoint;
            EndPoint Remote_EndPoint;
            Socket Ethernet_Socket;

            Random rnd = new Random();
            string SID = rnd.Next(1, 99).ToString("00");

            string[] D_parts = D_ip.Split('.');
            int D_fin = Convert.ToInt16(D_parts[3]);

            string DA1 = D_fin.ToString("x2").ToUpper();

            if (Global.settings.DA1 != DA1)
            {
                throw new Exception("configurazione di comunicazione errata (DNA) " + Global.settings.DNA + " <> " + DA1);
            }

            string[] S_parts = S_ip.Split('.');
            int S_fin = Convert.ToInt16(S_parts[3]);

            string SA1 = S_fin.ToString("x2").ToUpper();

            if (Global.settings.SA1 != SA1)
            {
                throw new Exception("configurazione di comunicazione errata (SNA) " + Global.settings.SNA + " <> " + SA1);
            }


            Header = Global.settings.ICF + Global.settings.RSV + Global.settings.GCT + Global.settings.DNA + Global.settings.DA1 + Global.settings.DA2 + Global.settings.SNA + Global.settings.SA1 + Global.settings.SA2 + SID;

            if (DEBUGMODE)
            {
                Console.WriteLine("Header : " + Header);
            }

            //0101820064000019

            string cmd_write = "0101";
            string cmd_DM = "82";
            string cmd_startaddress = dmnum.ToString("x4");
            string cmd_byteempty = "00";
            var qnt1 = qnt + 1;
            string cmd_wordnumber = qnt1.ToString("0000");

            CMND = Header + cmd_write + cmd_DM + cmd_startaddress + cmd_byteempty + cmd_wordnumber;

            if (DEBUGMODE)
            {
                Console.WriteLine("CMD : " + CMND);
            }

            //'txtSend.Text = ""
            CmdLength = CMND.Length;
            ByteArray = new byte[CmdLength / 2];

            for (X = 0; X < CmdLength; X += 2)
            {
                tmp1 = CMND.Substring(X, 2);
                ByteArray[Cnt] = Convert.ToByte(tmp1, 16);
                Cnt += 1;
            }

            if (DEBUGMODE)
            {
                Console.WriteLine("txtSend : " + ToHex(ByteArray));
            }

            try
            {
                Local_IP = IPAddress.Parse(S_ip);
            }
            catch (Exception e)
            {
                throw new Exception("invalid local IP address \r\n" + e);
            }

            try
            {
                Remote_IP = IPAddress.Parse(D_ip);
            }
            catch (Exception e)
            {
                throw new Exception("invalid PLC IP address \r\n" + e);
            }

            Remote_IPEndPoint = new IPEndPoint(Remote_IP, D_port);
            Remote_EndPoint = (EndPoint)Remote_IPEndPoint;
            Local_IPEndPoint = new IPEndPoint(Local_IP, S_port);

            Ethernet_Socket = new Socket(Local_IPEndPoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp);

            if (Ethernet_Socket != null)
            {
                Ethernet_Socket.SendTo(ByteArray, Remote_EndPoint); //send FINS cmd
                Ethernet_Socket.ReceiveTimeout = 200;

                try
                {
                    retval = Ethernet_Socket.ReceiveFrom(myByte, ref Remote_EndPoint);  //recv from socket
                    return ReadDM_Received_Data(myByte, retval, SID, qnt);      //call sub to process byte array
                }
                catch (Exception e)
                {
                    throw new Exception("No response from PLC \r\n\r\n" + e);
                }
            }
            else
            {
                throw new Exception("Errore apertura socket \r\n\r\n");
            }
        }

        public int[] ReadDM_Received_Data(Byte[] RX_Data, int RX_Count, string SID, int qnt)
        {
            int x = 0, l = 0, ln = 0;
            string t = "", chex = "", tr = "", resp = "", R = "";

            byte[] vtData;
            byte[] bytearr = new byte[1024];
            string[] dstrarr = new string[1024];
            string[] ascii = new string[1024];

            vtData = RX_Data;
            ln = RX_Count;

            for (l = 1; l <= ln; l++)
            {
                bytearr[l] = (byte)(Convert.ToByte(vtData[l - 1]));
                chex = bytearr[l].ToString("X2");
                dstrarr[l] = chex;
                resp += chex;
            }

            t = "  ICF RSV GCT DNA DA1 DA2 SNA SA1 SA2 SID MRC SRC MEC SEC\r\n";
            t = t + "  " + dstrarr[1] + "    " + dstrarr[2] + "    " + dstrarr[3] + "    " + dstrarr[4] + "    " + dstrarr[5] + "    " + dstrarr[6] + "    " + dstrarr[7] + "    " + dstrarr[8] + "    " + dstrarr[9] + "   " + dstrarr[10] + "    " + dstrarr[11] + "   " + dstrarr[12] + "    " + dstrarr[13] + "    " + dstrarr[14];

            if (dstrarr[10] != SID)
            {
                Console.WriteLine("SID Errato : " + dstrarr[10] + " <> " + SID);
            }

            if (DEBUGMODE)
            {
                Console.WriteLine("RESPOSE : " + string.Join(".", dstrarr.Take(1 + ln)));
            }

            for (x = 15; x < ln; x++)
            {
                if (bytearr[x] > 31 && bytearr[x] <= 255)
                {

                    ascii[x] = bytearr[x].ToString();
                }
                else
                {
                    ascii[x] = "0";
                }
            }

            tr = "";
            string txtrecived = "";
            for (x = 15; x < ln; x += 20)
            {
                tr = dstrarr[x] + dstrarr[x + 1] + " " + dstrarr[x + 2] + dstrarr[x + 3] + " " + dstrarr[x + 4] + dstrarr[x + 5] + " " + dstrarr[x + 6] + dstrarr[x + 7] + " " + dstrarr[x + 8] + dstrarr[x + 9] + " " + dstrarr[x + 10] + dstrarr[x + 11] + " " + dstrarr[x + 12] + dstrarr[x + 13] + " " + dstrarr[x + 14] + dstrarr[x + 15] + " " + dstrarr[x + 16] + dstrarr[x + 17] + " " + dstrarr[x + 18] + dstrarr[x + 19] + " | " + ascii[x] + ascii[x + 1] + ascii[x + 2] + ascii[x + 3] + ascii[x + 4] + ascii[x + 5] + ascii[x + 6] + ascii[x + 7] + ascii[x + 8] + ascii[x + 9] + ascii[x + 10] + ascii[x + 11] + ascii[x + 12] + ascii[x + 13] + ascii[x + 14] + ascii[x + 15] + ascii[x + 16] + ascii[x + 17] + ascii[x + 18] + ascii[x + 19];
                txtrecived += tr;
            }

            if (DEBUGMODE)
            {
                Console.WriteLine("TXT RECIVED : " + txtrecived);
            }

            if (dstrarr[13] != "00" || dstrarr[14] != "00")
            {
                throw new Exception("Comando errato : " + txtrecived);
            }

            int[] array = new int[qnt + 1];
            int indice = 0;
            int limite = qnt * 2;


            for (int r = 0; r <= limite; r += 2)
            {
                string hex = dstrarr[15 + r] + dstrarr[15 + r + 1];
                int valore = Convert.ToInt32(hex, 16);
                array[indice] = valore;
                indice++;
            }

            return array;
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
    }
}
