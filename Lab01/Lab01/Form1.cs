using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baitap1 baitap1 = new baitap1();
            baitap1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baitap2 baitap2 = new baitap2();
            baitap2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baitap3 baitap3 = new baitap3();
            baitap3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baitap4 baitap4 = new baitap4();
            baitap4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baitap5 baitap5 = new baitap5();
            baitap5.ShowDialog();
        }
    }
}
