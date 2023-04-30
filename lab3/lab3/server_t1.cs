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

namespace lab3
{
    public partial class server_t1 : Form
    {
        public server_t1()
        {
            InitializeComponent();
        }
        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(int.Parse(tb_Port.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString();
                //Viết hàm InfoMessage để hiển thị thông điệp lên List View
                InfoMessage(mess);
            }
        }
        public void InfoMessage(string text)
        {
            rtb_Receive.Text += text + "\n";
        }
        private void server_t1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_Port.Text, out int Port))
            {
                MessageBox.Show("yêu cầu nhập đúng port là kiểu số nguyên!");
                tb_Port.Text = "";
                return;
            }
            CheckForIllegalCrossThreadCalls = false;
            btn_Listen.Enabled = false;
            tb_Port.ReadOnly = true;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        private void rtb_Receive_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
