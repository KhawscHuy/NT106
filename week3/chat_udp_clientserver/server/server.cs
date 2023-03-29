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
using System.Threading;

namespace server
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            txt_port.ReadOnly = true;
            btn_connect.Enabled = false;
            thdUDPServer.Start();

        }
        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(int.Parse(txt_port.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                this.Invoke((MethodInvoker)delegate {
                    lbConnections.Items.Add(RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString());
                });
            }
            
        }
        private void server_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_port_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(txt_port.Text, out int port)&& txt_port.Text != "")
            {
                MessageBox.Show("please fill right port");
                txt_port.Text = "";
                return;
            }
        }
    }
}
