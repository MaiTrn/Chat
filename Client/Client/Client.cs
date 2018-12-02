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
        const int PORTNUM = 8910;
        private IPEndPoint localIP;
        private Socket client;
        private string user;
        private string altuser;

        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.AcceptButton = btnSend;
            listBoxUsers.TabStop = false;
            txtboxMsg.TabStop = false;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Show();
            Connect();
            AttemptLogin();
            btnPubChat.Checked = true;
            client.Send(Serialize("REQUESTUSERS"));
        }

        private void AttemptLogin()
        {
            
            frmLogin login = new frmLogin();
            login.ShowDialog(this);
            if(login.DialogResult == DialogResult.OK)
            {
                user = login.txtlogin.Text;
                client.Send(Serialize("CONNECT|" + user));
                lbName.Text += user;
            }
            if(login.DialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text != string.Empty)
            {
                Send();
                if (btnPrivChat.Checked == true)
                    AddMessage("(Private) " + user + ": " + txtMessage.Text);
                else if (btnPubChat.Checked == true)
                    AddMessage(user + ": " + txtMessage.Text);
            }
        }

        //connect, disconnect, gui tin, nhan tin tu server
        #region Cac ham xu ly co ban
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
                MessageBox.Show("Can't connect to server!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
                Close();
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
            if (btnPubChat.Checked == true && txtMessage.Text != string.Empty)
                client.Send(Serialize("CHAT|" + user + ": " + txtMessage.Text));
            else if (btnPrivChat.Checked == true && txtMessage.Text != string.Empty)
                client.Send(Serialize("PCHAT|(Private) " + user + ": " + txtMessage.Text + "|" + altuser));
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
                    ReceivedCmd(message);
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
            
            txtboxMsg.AppendText(s + Environment.NewLine);   
            
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
        #endregion

        //tin nhan duoc tu server se dua vao day xu ly
        #region Ham xu ly lenh nhan dc tu server
        private void ReceivedCmd(string data)
        {
            string[] dataArray = data.Split('|');
            switch (dataArray[0])
            {
               case "CHAT":            // gui tin nhan
                    AddMessage(dataArray[1]);
                    break;
                case "REQUESTUSERS":    // yeu cau gui list user dang online
                    ListUsers(dataArray[1]);
                    break;
                case "PRIVATECHAT":     // chat rieng
                    ChatPrivate(dataArray[1]);
                    break;
                case "PUBLICCHAT":      // quay lai chat chung
                    btnPubChat.Checked = true;
                    break;
                default:
                    AddMessage("Unknown message:" + dataArray[0]);
                    break;
            }
        }

        private void ListUsers(string data)
        {
            string[] Users = data.Split(',');
            int flag = 0;
            listBoxUsers.Items.Clear();
            foreach (string user in Users)
            {
                if(user != "")
                    listBoxUsers.Items.Add(user);
                if(btnPrivChat.Checked == true && user == altuser)
                {
                    flag = 1;
                }
            }
            if (flag == 0 && btnPrivChat.Checked == true)
                btnPubChat.Checked = true;
        }

        private void ChatPrivate(string name)
        {
            altuser = name;
            btnPrivChat.Checked = true;
        }
        #endregion

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (user != null)
            {
                client.Send(Serialize("DISCONNECT|" + user));
            }
            Disconnect();
        }

        #region Buttons
        private void btnPrivChat_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                altuser = listBoxUsers.SelectedItem.ToString();
                if (altuser != user)
                {
                    client.Send(Serialize("PRIVATECHAT|" + altuser));
                    listBoxUsers.ClearSelected();
                }
                else
                {
                    MessageBox.Show("You can't talk to yourself!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listBoxUsers.ClearSelected();
                    btnPrivChat.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Please select someone to talk to!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnPrivChat.Checked = false;
                listBoxUsers.ClearSelected();
            }
        }

        private void btnPubChat_Click(object sender, EventArgs e)
        {
            AddMessage("**You are in a public chat!**");
            client.Send(Serialize("PCHAT|**You are in a public chat!**|" + altuser));
        }

        private void btnPrivChat_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPrivChat.Checked == true)
                btnPubChat.Checked = false;
            else btnPubChat.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
