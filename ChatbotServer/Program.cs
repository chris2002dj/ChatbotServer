﻿using System;
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
        }
    }
}
