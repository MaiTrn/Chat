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

namespace Client
{
    public partial class Client : Form
    {
        private Thread listenerThread;
        const int PORTNUM = 8000;
        private IPEndPoint localIP;
        private Socket client;
        private string user;
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.AcceptButton = btnSend;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            Connect();
            AttemptLogin();
        }

        private void AttemptLogin()
        {
            
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK)
            {
                user = login.txtlogin.Text;
            }
            if(login.DialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(user + ": " + txtMessage.Text);
        }

        /// <summary>
        /// mo ket noi
        /// </summary>
        public void Connect()
        {
            
            localIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), PORTNUM);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(localIP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            listenerThread = new Thread(Receive);
            listenerThread.IsBackground = true;
            listenerThread.Start();

        }

        /// <summary>
        /// dong ket noi
        /// </summary>
        public void Disconnect()
        {
           client.Close();
        }

        /// <summary>
        /// gui tin
        /// </summary>
        public void Send()
        {
            if (txtMessage.Text != string.Empty)
                client.Send(Serialize(user + ": " + txtMessage.Text));
        }

        /// <summary>
        /// nhan tin
        /// </summary>
        public void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Disconnect();
            }

        }

        /// <summary>
        /// them message
        /// </summary>
        /// <param name="s"></param>
        public void AddMessage(string s)
        {
            listBoxStatus.Items.Add(s);
            txtMessage.Clear();
        }

        /// <summary>
        /// phan manh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        /// <summary>
        /// gom manh
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }
    }
}
