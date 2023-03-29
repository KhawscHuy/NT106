using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class baitap1 : Form
    { 
        //khai bao bien toan cuc de dong bo du lieu khung textbox
        ulong n1;
        ulong n2;
        public baitap1()
        {
            InitializeComponent();
        }
        private void baitap1_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //cho phep doc
            ans.ReadOnly = true;
            //kiem tra du lieu
            if (num1.Text != "" && !ulong.TryParse(num1.Text, out n1))
            {
                MessageBox.Show("Vui lòng nhập số!");
                num1.Text = "";
                return;
            }
            //xuat ra textbox
            ans.Text = (n1 + n2).ToString();
        }
        private void num2_TextChanged(object sender, EventArgs e)
        {
            //cho phep doc
            ans.ReadOnly = true;
            //gan gia tri trong textbox vao n2
            ulong.TryParse(num2.Text, out n2);
            //kiem tra du lieu
            if (num2.Text != "" && !ulong.TryParse(num2.Text, out n2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                num2.Text = "";
                return;
            }
            //xuat ra textbox
            ans.Text = (n1 + n2).ToString();
        }
        private void ans_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
