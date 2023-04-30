using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class client_t3 : Form
    {
        public client_t3()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            btn_Send.Enabled = false;
            btn_Disconnect.Enabled = false;
        }
        IPEndPoint ipClient;
        Socket socket;
        private void client_t3_Load(object sender, EventArgs e)
        {

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            ipClient = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ipClient);
            btn_Connect.Enabled = false;
            btn_Disconnect.Enabled = true;
            btn_Send.Enabled = true;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {

            byte[] data = Encoding.UTF8.GetBytes(rtb_Message.Text);
            socket.Send(data);
            rtb_Message.Text = "";
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            socket.Close();
            btn_Connect.Enabled = true;
            btn_Disconnect.Enabled = false;
            btn_Send.Enabled = false;
        }

        private void rtb_Message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
