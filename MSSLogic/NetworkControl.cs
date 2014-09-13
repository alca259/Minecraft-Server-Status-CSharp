using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using MSSUtils.Exceptions;

namespace MSSLogic
{
    public class NetworkControl
    {
        #region Properties
        // Public properties
        public static long responseTime { get; set; }
        public UdpClient udpClient { get; set; }

        // Private properties
        private string serverHost { get; set; }
        private int serverPort { get; set; }
        private int timeoutPing { get; set; }
        private bool messageReceived { get; set; }
        private byte[] outputBytes { get; set; }
        private MagicPacket mp { get; set; }
        #endregion

        #region Variables
        private IPEndPoint receivePoint;
        private IPEndPoint endPoint;
        private static IPAddress[] serverIpAddresses;
        #endregion

        #region Constructors
        public NetworkControl(string pServerHost = "127.0.0.1", int pServerPort = 25565)
        {
            // Initialize data
            timeoutPing = 3000;
            responseTime = 0;
            serverIpAddresses = new IPAddress[]{};
            udpClient = new UdpClient();
            serverHost = pServerHost;
            serverPort = pServerPort;
            messageReceived = false;
            mp = new MagicPacket();
        }
        #endregion

        #region Methods
        private bool PingServer()
        {
            try
            {
                Ping p = new Ping();
                // Sending ping to server
                PingReply reply = p.Send(serverHost, 3000);

                // If not reply, server is offline
                if (reply == null) return false;

                // Get time of response
                responseTime = reply.RoundtripTime;

                // Return if the server is OK or not
                return reply.Status == IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SetUdpClient(int startPort = 25584)
        {
            try
            {
                serverIpAddresses = new IPAddress[] { };
                serverIpAddresses = Dns.GetHostAddresses(serverHost);
            }
            catch (SocketException)
            {
                throw new UnknownHostException();
            }

            // Default IP Address
            if (serverIpAddresses.Length == 0)
            {
                serverIpAddresses[0] = new IPAddress(new byte[] { 127, 0, 0, 1 });
            }

            receivePoint = new IPEndPoint(IPAddress.Any, startPort);
            endPoint = new IPEndPoint(serverIpAddresses.First(), serverPort);
            udpClient = new UdpClient();
        }

        public int GetHandShake()
        {
            return mp.Handshake();
        }

        public byte[] GetFullStats(int token)
        {
            return mp.FullStats(token);
        }

        protected byte[] ConnectToServer(byte[] inputBytes)
        {
            // Ping minecraft server
            if (!PingServer()) throw new UnknownHostException();

            // Connecting with minecraft server
            udpClient.Connect(endPoint);

            // Sending data
            udpClient.Send(inputBytes, inputBytes.Length);

            // Cleaning data of output
            outputBytes = new byte[] { };
            messageReceived = false;

            // Set datetime of timeout
            DateTime endTimeout = DateTime.Now.AddMilliseconds(timeoutPing);

            // Receiving data async
            udpClient.BeginReceive(ReceiveCallback, receivePoint);

            while (!messageReceived)
            {
                Thread.Sleep(100);
                if (DateTime.Now > endTimeout)
                {
                    throw new TimeoutException("The server does not respond at specified port");
                }
            }

            // Receiving data sync - Block application if not receive data of port
            // byte[] outputBytes = udpClient.Receive(ref receivePoint);

            // Returning data
            return outputBytes;
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            outputBytes = udpClient.EndReceive(ar, ref receivePoint);
            messageReceived = true;
        }
        #endregion
    }
}
