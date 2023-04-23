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
    }
}
