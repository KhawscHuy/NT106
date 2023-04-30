using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client_t1 client_T1 = new client_t1();
            client_T1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server_t1 server_T1 = new server_t1();
            server_T1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            server_t2 server_T2 = new server_t2();
            server_T2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            client_t3 client_T3 = new client_t3();
            client_T3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            server_t3 server_T3 = new server_t3();
            server_T3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            client_t4 client_T4 = new client_t4();
            client_T4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            server_t4 server_T4 = new server_t4();
            server_T4.Show();

        }
    }
}
