using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Client.Resources;
using Client.Utils;

namespace Client.Logic
{
    public class MCQuery
    {
        #region Vars
        private string _serverHost = "127.0.0.1";
        private int _serverPort = 25565;
        private IPAddress[] hostIpAddresses;
        private UdpClient udpClient = new UdpClient();
        private IPEndPoint receivePoint;
        private IPEndPoint endPoint;
        #endregion

        #region Connect UDP
        private void StartUdpClient()
        {
            try
            {
                hostIpAddresses = new IPAddress[]{};
                hostIpAddresses = Dns.GetHostAddresses(_serverHost);
            }
            catch (SocketException)
            {
                throw new UnknownHostException();
            }

            // Default IP Address
            if (hostIpAddresses.Length == 0)
            {
                hostIpAddresses[0] = new IPAddress(new byte[] { 127, 0, 0, 1 });
            }

            receivePoint = new IPEndPoint(IPAddress.Any, 25584);
            endPoint = new IPEndPoint(hostIpAddresses.First(), _serverPort);
            udpClient = new UdpClient();
        }

        private bool PingServer()
        {
            Ping p = new Ping();
            PingReply reply = p.Send(hostIpAddresses.First(), 3000);
            return reply != null && reply.Status == IPStatus.Success;
        }

        private byte[] Connect(byte[] inputBytes)
        {
            // Ping minecraft server
            if (!PingServer()) throw new UnknownHostException();

            // Connecting with minecraft server
            udpClient.Connect(endPoint);

            // Sending data
            udpClient.Send(inputBytes, inputBytes.Length);

            // Receiving data sync
            byte[] outputBytes = udpClient.Receive(ref receivePoint);

            // Returning data
            return outputBytes;
        }
        #endregion

        #region Minecraft Query Protocol
        private int Handshake()
        {
            // Declare vars
            MemoryStream stream = new MemoryStream();

            // Writing stream bytes
            stream.WriteByte(0xFE); // Magic
            stream.WriteByte(0xFD); // Magic
            stream.WriteByte(0x09); // Type
            stream.WriteByte(0x01); // Session
            stream.WriteByte(0x01); // Session
            stream.WriteByte(0x01); // Session
            stream.WriteByte(0x01); // Session

            // Preparing byte array
            byte[] sendme = stream.ToArray();

            // Closing stream for save resources
            stream.Close();

            // Returned data
            byte[] receivedBytes = Connect(sendme);

            string number = "";

            for (int i = 0; i < receivedBytes.Length; i++)
            {
                if (i > 4 && receivedBytes[i] != 0x00)
                {
                    number += (char)receivedBytes[i];
                }
            }

            // Return token
            return int.Parse(number);
        }

        private byte[] FullStats(int number)
        {
            // Declare vars
            MemoryStream stream = new MemoryStream();
            byte[] numberbytes = BitConverter.GetBytes(number).Reverse().ToArray();

            // Writing stream bytes
            stream.WriteByte(0xFE); // Magic
            stream.WriteByte(0xFD); // Magic
            stream.WriteByte(0x00); // Type
            stream.WriteByte(0x01); // Session
            stream.WriteByte(0x01); // Session
            stream.WriteByte(0x01); // Session
            stream.WriteByte(0x01); // Session
            stream.Write(numberbytes, 0, 4); // Challenge
            stream.WriteByte(0x00); // Padding
            stream.WriteByte(0x00); // Padding
            stream.WriteByte(0x00); // Padding
            stream.WriteByte(0x00); // Padding

            // Preparing byte array
            byte[] sendme = stream.ToArray();

            // Closing stream for save resources
            stream.Close();

            // Return data
            return Connect(sendme);
        }
        #endregion

        #region Main function
        public QueryResponse Query(string serverHost, int serverPort)
        {
            QueryResponse response = new QueryResponse();
            // Assign data of server to query
            _serverHost = serverHost;
            _serverPort = serverPort;

            try
            {
                // Start client
                StartUdpClient();
                // Send handshake
                int token = Handshake();
                // Obtain full data
                byte[] data = FullStats(token);
                // Codificamos
                data = Encoding.Convert(Encoding.GetEncoding("iso-8859-1"), Encoding.UTF8, data);
                // Mapeamos las respuestas a un modelo
                response = new QueryResponse(data);
            }
            catch (UnknownHostException ex)
            {
                Logger.Warn(Messages.UnknownHost, ex);
                MessageBox.Show(ex.Message, Messages.ServerError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SocketException ex)
            {
                Logger.Error(Messages.ServerError, ex);
                MessageBox.Show(ex.Message, Messages.ServerError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Logger.Fatal(Messages.ServerError, ex);
                MessageBox.Show(ex.Message, Messages.ServerError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Devolvemos el modelo al formulario
            return response;
        }
        #endregion
    }
}
