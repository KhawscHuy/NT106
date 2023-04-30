using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class server_t3 : Form
    {
        private IPEndPoint TCP;
        private Socket server;
        private List<Socket> clientList;

        bool isListen = false;
        IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);

        Thread serverThread;
        Socket listenSocket;

        public server_t3()
        {
            InitializeComponent();
        }
        void Receive(Socket client)
        {
            try
            {
                while (true)
                {

                    byte[] data = new byte[1024];
                    int received = client.Receive(data);
                    if (received == 0)
                    {
                        lv_ShowMessage.Items.Add(new ListViewItem() { Text = "Client disconnected" });
                        break;
                    }
                    else
                    {
                        string message = Encoding.UTF8.GetString(data);
                        lv_ShowMessage.Items.Add(new ListViewItem() { Text = "From client: " + message });
                    }
                }
            }
            catch { }
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            TCP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(TCP);
            lv_ShowMessage.Items.Add("Server started! \n");
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        Thread ReceiveThread = new Thread(() => Receive(client));
                        ReceiveThread.IsBackground = true;
                        ReceiveThread.Start();
                        lv_ShowMessage.Items.Add("Connection accepted from 127.0.0.1:9999");
                    }
                }
                catch
                {
                    TCP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
            btn_Listen.Enabled=false;
        }

        private void server_t3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listenSocket != null) listenSocket.Close();
            if (serverThread != null) serverThread.Abort();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
