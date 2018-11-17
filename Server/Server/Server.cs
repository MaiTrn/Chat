using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public partial class frmServer : Form
    {
        private Thread listenerThread;
        const int PORTNUM = 8910;
        private IPEndPoint localIP;
        private Socket server;
        private List<ClientInfo> clientList;


        public frmServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.AcceptButton = btnSend;
            
        }

        
        private void frmServer_Load(object sender, EventArgs e)
        {
            Connect();
            AddMessage("Ready to connect");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text != string.Empty)
            {
                foreach (ClientInfo client in clientList)
                {
                    Send(("CHAT|Server: " + txtMessage.Text), client);
                }
                AddMessage("Server: " + txtMessage.Text);
                txtMessage.Clear();
            }
            
        }

        //tuy theo tung lenh user gui den, duoc ngan cach boi dau |
        //co cach xu ly khac nhau
        //them chuc nang cho form vao day
        #region Xu ly Request tu nguoi dung
        private void OnLineReceived(string data, ClientInfo sender)
        {
            string[] dataArray = data.Split('|');
            switch (dataArray[0])
            {
                case "CONNECT":         //nguoi dung dang nhap
                    ConnectUser(dataArray[1], sender);
                    break;
                case "DISCONNECT":      // nguoi dung thoat
                    DisconnectUser(dataArray[1], sender);
                    break;
                case "CHAT":            //gui tin nhan
                    SendChat(dataArray[1], sender);
                    break;
                case "REQUESTUSERS":    // yeu cau gui list user dang online
                    ListUsers(sender);
                    break;
                case "PRIVATECHAT":
                    ChatPrivate(dataArray[1], sender);
                    break;
                case "PCHAT":
                    SendPChat(dataArray[1], dataArray[2]);
                    break;
                default:
                    AddMessage("Unknown message: " + data);
                    break;
            }
        }

        private void ConnectUser(string Name, ClientInfo client)
        {
            client.Name = Name;
            clientList.Add(client);
            AddMessage(client.Name + " just logged in");
            foreach (ClientInfo item in clientList)
            {
                Send("CHAT|" + client.Name + " just logged in", item);
            }

        }
        private void ListUsers(ClientInfo client)
        {
            string ListedUsers = "REQUESTUSERS|";
            foreach (ClientInfo item in clientList)
            {
                ListedUsers = ListedUsers + item.Name + ",";
            }
            Send(ListedUsers, client);
        }
        private void SendChat(string message, ClientInfo client)
        {
            try
            {
                foreach (ClientInfo item in clientList)
                {
                    if (item.ClientSocket != null && item.Name != client.Name)
                         Send(("CHAT|" + message), item);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.ClientSocket.Close();
            }
        }
        private void DisconnectUser(string data, ClientInfo client)
        {
            AddMessage(data + " just logged out");
            foreach (ClientInfo item in clientList)
            {
                if(item.Name != client.Name)
                    Send("CHAT|" + data + " just logged out", item);
            }
            clientList.Remove(client);
            client.ClientSocket.Close();
        }
        private void ChatPrivate(string data, ClientInfo client)
        {
            AddMessage(client.Name + " is in a private chat with " + data);
            int i = 0;
            for(int j = 0; j < clientList.Count; j++)
            {
                if (data == clientList[j].Name)
                {
                    i = j;
                }
            }
            Send("PRIVATECHAT|" + client.Name, clientList[i]);
            Send("CHAT|**You are in a private chat with " + client.Name + "**", clientList[i]);
            Send("CHAT|**You are in a private chat with " + data + "**", client);
        }
        private void SendPChat(string message, string name)
        {
            foreach(ClientInfo item in clientList)
            {
                if(item.Name == name )
                {
                    if(message.CompareTo("**You are in a public chat!**") == 0)
                    {
                        Send("PUBLICCHAT|", item);
                        AddMessage("Ended private chat");
                    }
                    Send("CHAT|" + message, item);
                }                    
            }
        }
        #endregion

        //connect voi client, lang nghe client
        #region Tao ket noi
        public void Connect()
        {
            clientList = new List<ClientInfo>();
            localIP = new IPEndPoint(IPAddress.Any, PORTNUM);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(localIP);

            listenerThread = new Thread(() =>
            {
                try
                {
                    while(true)
                    {
                        server.Listen(100);
                        ClientInfo client = new ClientInfo(server.Accept());
                        client.ReceivedCmd += new ReceiveCmd(OnLineReceived);
                        
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    localIP = new IPEndPoint(IPAddress.Any, PORTNUM);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }
        #endregion
        
        //dong server
        #region Dong ket noi
        public void Disconnect()
        {
            server.Close();
        }
        #endregion

        #region Server gui tin
        public void Send(string msg, ClientInfo client)
        {
            if (client.ClientSocket != null && msg != string.Empty)
            {
                client.ClientSocket.Send(Serialize(msg));
            }
              
        }
        #endregion

        //nhan tin tu client, dua qua cho ham xu ly request tiep tuc xu ly
        #region Xu ly tin nhan duoc tu client
        public void Receive(object obj)
        {
            ClientInfo client = obj as ClientInfo;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.ClientSocket.Receive(data);
                    string message = (string)Deserialize(data);
                    client.SendData(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.ClientSocket.Close();
            }

        }
        #endregion

        #region Them tin nhan vao msg box
        public void AddMessage(string s)
        {
            txtboxStatus.AppendText(s + Environment.NewLine);
            txtMessage.Clear();
        }
        #endregion

        #region Phan manh du lieu nhan duoc thanh cac mang bye
        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        #endregion

        #region Gom nhom cac mang byte thanh du lieu
        private object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
        #endregion

        //dong form
        private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }
    }
}
