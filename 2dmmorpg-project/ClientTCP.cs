﻿using System;
using System.Net.Sockets;

namespace _2dmmorpg_project
{
    class ClientTCP
    {
        public TcpClient PlayerSocket;
        public NetworkStream myStream;

        public void ConnectToServer()
        {
            PlayerSocket = new TcpClient();
            PlayerSocket.ReceiveBufferSize = 4096;
            PlayerSocket.SendBufferSize = 4096;
            PlayerSocket.NoDelay = false;
            PlayerSocket.BeginConnect("127.0.0.1", 5555, ConnectCallBack, PlayerSocket);
        }

        private void ConnectCallBack(IAsyncResult ar)
        {

        }
    }
}
