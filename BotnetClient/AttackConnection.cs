﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BotnetClient
{
    class AttackConnection
    {
        public Thread attackThread = null;
        public Socket attackSocket = null;
        public string guid = Guid.NewGuid().ToString();
        public string name = "";

        public AttackConnection()
        {

        }
    }
}
