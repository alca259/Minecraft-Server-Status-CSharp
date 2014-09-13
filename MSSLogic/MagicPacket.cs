using System;
using System.IO;
using System.Linq;

namespace MSSLogic
{
    public class MagicPacket : NetworkControl
    {
        #region Connection to Minecraft Server
        public int Handshake()
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
            byte[] receivedBytes = ConnectToServer(sendme);

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

        public byte[] FullStats(int number)
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
            return ConnectToServer(sendme);
        }
        #endregion
    }
}