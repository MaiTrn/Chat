using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    //delegate để handle request từ phía user
    public delegate void ReceiveCmd(string data, ClientInfo c);


    //class chứa socket và thông tin của 1 user cụ thể
    public class ClientInfo
    {
        private string name;
        private Socket client;

        /// <summary>
        /// ten nguoi dung de phan biet
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public ClientInfo(Socket c)
        {
            this.client = c;
        }

        public Socket ClientSocket
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }

        public event ReceiveCmd ReceivedCmd;

        public void SendData(string mydata)
        {
            ReceivedCmd(mydata, this);
        }
    }
}
