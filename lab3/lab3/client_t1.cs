using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class client_t1 : Form
    {
        public client_t1()
        {
            InitializeComponent();
            btn_Send.Enabled = false;
        }

        private void client_t1_Load(object sender, EventArgs e)
        {

        }
        UdpClient client ;
        int Port;
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            //kiem tra gia tri
   
            if (!IPAddress.TryParse(tb_IpAddr.Text, out IPAddress IP) )
            {
                MessageBox.Show("yêu cầu nhập đúng địa chỉ IP!");
                tb_IpAddr.Text = "";
                return;
            }
            if (!int.TryParse(tb_Port.Text, out Port) )
            {
                MessageBox.Show("yêu cầu nhập đúng port là kiểu số nguyên!");
                tb_Port.Text = "";
                return;
            }
            btn_Connect.Enabled = false;
            btn_Send.Enabled = true;
            tb_IpAddr.ReadOnly= true;
            tb_Port.ReadOnly = true;
            client = new UdpClient();
            MessageBox.Show("kết nối thành công!!!");
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Byte[] sendBytes = Encoding.UTF8.GetBytes(rtb_Message.Text);
            client.Send(sendBytes, sendBytes.Length, tb_IpAddr.Text, Port);
            rtb_Message.Text = "";
        }

        private void rtb_Message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
