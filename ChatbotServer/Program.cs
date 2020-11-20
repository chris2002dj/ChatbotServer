using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatbotServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipaddress = IPAddress.Any;

            IPEndPoint ipEnd = new IPEndPoint(ipaddress, 23000);

            listenerSocket.Bind(ipEnd);

            listenerSocket.Listen(5);
            Console.WriteLine("Server in ascolto...");
            Console.WriteLine("Attendo una connessione da parte di un client");

            Socket client = listenerSocket.Accept();

            Console.WriteLine("Client IP: " + client.RemoteEndPoint.ToString());

            byte[] buffer = new byte[128];
            int receivedBytes, sendedBytes;
            string receivedString, sendString;

            while (true)
            {
                receivedBytes = client.Receive(buffer);
                receivedString = Encoding.ASCII.GetString(buffer, 0, receivedBytes);

                if (receivedString.IndexOf("\n") == -1)
                {

                }
        }
    }
}
