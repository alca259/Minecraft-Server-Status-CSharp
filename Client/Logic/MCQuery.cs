using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client.Logic
{
    public class MCQuery
    {
        private string _serverHost = "127.0.0.1";
        private int _serverPort = 25565;
        private UdpClient udpClient = new UdpClient();
        private IPEndPoint receivePoint;
        private IPEndPoint endPoint;

        private void StartUdpClient()
        {
            IPAddress[] hostIpAddresses = Dns.GetHostAddresses(_serverHost);

            // Default IP Address
            if (hostIpAddresses.Length == 0)
            {
                hostIpAddresses[0] = new IPAddress(new byte[] { 127, 0, 0, 1 });
            }

            receivePoint = new IPEndPoint(IPAddress.Any, 25584);
            endPoint = new IPEndPoint(hostIpAddresses.First(), _serverPort);
            udpClient = new UdpClient();
        }

        private byte[] Connect(byte[] inputBytes)
        {
            // Connecting with minecraft server
            udpClient.Connect(endPoint);

            // Sending data
            udpClient.Send(inputBytes, inputBytes.Length);

            // Receiving data
            byte[] outputBytes = udpClient.Receive(ref receivePoint);

            // Returning data
            return outputBytes;
        }

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

        public void Query(string serverHost, int serverPort)
        {
            // Assign data of server
            _serverHost = serverHost;
            _serverPort = serverPort;
            // Start client
            StartUdpClient();
            // Send handshake
            int token = Handshake();
            // Obtain full data
            byte[] data = FullStats(token);

            // Codificamos
            data = Encoding.Convert(Encoding.GetEncoding("iso-8859-1"), Encoding.UTF8, data);

            QueryResponse response = new QueryResponse(data);
        }
    }
}
