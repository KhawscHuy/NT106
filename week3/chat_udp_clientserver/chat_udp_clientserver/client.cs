using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_udp_clientserver
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }
        UdpClient udpClient;
        private void txt_Mess_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Byte[] sendBytes = Encoding.UTF8.GetBytes(txt_Mess.Text);
            udpClient.Send(sendBytes, sendBytes.Length);
            txt_Mess.Text = "";
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            udpClient = new UdpClient();
            if (txt_IP.Text == "")
            {
                txt_IP.Text = "localhost";
            }
            int port = int.Parse(txt_port.Text);
            udpClient.Connect(txt_IP.Text, port);
            this.btn_send.Enabled = true;
            this.btn_con.Enabled = false;
            txt_port.ReadOnly= true;
            txt_IP.ReadOnly = true;
        }
    }
}
