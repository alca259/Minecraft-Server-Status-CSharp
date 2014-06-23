using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Client.Logic
{
    public static class Test
    {
        public static void Testing()
        {
            Console.WriteLine("Connect");
            IPEndPoint recpoint = new IPEndPoint(IPAddress.Any, 25584);
            IPEndPoint endpoint = new IPEndPoint(new IPAddress(new byte[] { 87, 235, 219, 212 }), 25565);
            UdpClient client = new UdpClient();
            client.Connect(endpoint);
            MemoryStream ms = new MemoryStream();
            ms.WriteByte(0xFE); // Magic
            ms.WriteByte(0xFD); // Magic
            ms.WriteByte(0x09); // Type
            ms.WriteByte(0x01); // Session
            ms.WriteByte(0x01); // Session
            ms.WriteByte(0x01); // Session
            ms.WriteByte(0x01); // Session
            byte[] sendme = ms.ToArray();
            client.Send(sendme, sendme.Length);
            Console.WriteLine("Sent Handshake " + sendme.Length);
            ms.Close();
            Console.WriteLine("Read");
            byte[] rec = client.Receive(ref recpoint);
            Console.WriteLine("Got " + rec.Length + " from " + recpoint.ToString());
            Console.Write("Appears to be: ");
            string number = "";
            for (int i = 0; i < rec.Length; i++)
            {
                Console.Write(((int)rec[i]).ToString() + " ");
                if (i > 4 && rec[i] != 0x00)
                {
                    number += (char)rec[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Number is " + number + ", which is " + int.Parse(number));
            ms = new MemoryStream();
            ms.WriteByte(0xFE); // Magic
            ms.WriteByte(0xFD); // Magic
            ms.WriteByte(0x00); // Type
            ms.WriteByte(0x01); // Session
            ms.WriteByte(0x01); // Session
            ms.WriteByte(0x01); // Session
            ms.WriteByte(0x01); // Session
            byte[] numberbytes = BitConverter.GetBytes(int.Parse(number)).Reverse().ToArray();
            ms.Write(numberbytes, 0, 4); // Challenge
            ms.WriteByte(0x00); // Padding
            ms.WriteByte(0x00); // Padding
            ms.WriteByte(0x00); // Padding
            ms.WriteByte(0x00); // Padding
            sendme = ms.ToArray();
            client.Send(sendme, sendme.Length);
            Console.WriteLine("Sent Request " + sendme.Length);
            Console.Write("Sent:");
            for (int i = 0; i < sendme.Length; i++)
            {
                Console.Write(((int)sendme[i]).ToString() + " ");
            }
            Console.WriteLine();
            ms.Close();
            Console.WriteLine("Read");
            rec = client.Receive(ref recpoint);
            Console.WriteLine("Got " + rec.Length + " from " + recpoint.ToString());
            Console.WriteLine("Write");
            File.WriteAllBytes("output.log", rec);
            Console.WriteLine("Done!");
            Console.Read();
        }
    }
}