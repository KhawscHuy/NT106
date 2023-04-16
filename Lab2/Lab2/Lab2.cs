using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void btn_exercise1_Click(object sender, EventArgs e)
        {
            baitap1 baitap1 = new baitap1(); ;
            baitap1.ShowDialog();
        }

        private void btn_exercise2_Click(object sender, EventArgs e)
        {
            baitap2 baitap2 = new baitap2(); ;
            baitap2.ShowDialog();
        }

        private void btn_exercise3_Click(object sender, EventArgs e)
        {
            baitap3 baitap3 = new baitap3(); ;
            baitap3.ShowDialog();
        }

        private void btn_exercise4_Click(object sender, EventArgs e)
        {
            baitap4 baitap4 = new baitap4(); ;
            baitap4.ShowDialog();
        }

        private void btn_exercise5_Click(object sender, EventArgs e)
        {
            baitap5 baitap5 = new baitap5(); ;
            baitap5.ShowDialog();
        }

        private void btn_exercise6_Click(object sender, EventArgs e)
        {
            baitap6 baitap6 = new baitap6(); ;
            baitap6.ShowDialog();
        }
    }
}
