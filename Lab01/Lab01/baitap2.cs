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
    public partial class baitap2 : Form
    {
        public baitap2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {}
      

        private void button1_Click(object sender, EventArgs e)
        {
            // cho phep doc
            Max.ReadOnly = true;
            Min.ReadOnly = true;
            //luu gia tri cac text box vao n1 n2 n3
            double.TryParse(num1.Text, out double n1);
            double.TryParse(num2.Text, out double n2);
            double.TryParse(num3.Text, out double n3);
            //kiem tra dieu kien
            if (n1 > n2)
            {
                if(n1 > n3)
                {
                    Max.Text = num1.Text;
                    if(n2 > n3)
                    {
                        Min.Text = num3.Text;
                     
                        return;
                    }
                    Min.Text = num2.Text;
                    
                    return;
                }
                else
                {
                    Max.Text = num3.Text;
                    Min.Text = num2.Text;
                    return;
                }

            }
            else // n2 > n1
            {
                if (n1 > n3)
                {
                    Max.Text = num2.Text;
                    Min.Text = num3.Text;
                    return;
                }
                else //n3 > n1
                {
                    if(n2 > n3)
                    {
                        Max.Text = num2.Text;
                        Min.Text = num1.Text;
                        return;
                    }
                    Max.Text = num3.Text;
                    Min.Text = num1.Text;
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //xoa
            num1.Text = "";
            num2.Text = "";
            num3.Text = "";
            Max.Text = "";
            Min.Text = "";
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //thoat 
            MessageBox.Show("Cám ơn đã sử dụng chương trình!!!");
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //kiem tra du lieu num1
            if (num1.Text!=""&&!double.TryParse(num1.Text, out double n1) )
            {
                MessageBox.Show("Vui lòng nhập số!");
                num1.Text = "";
                return;
            }
        }
        private void num2_TextChanged(object sender, EventArgs e)
        {
            //kiem tra du lieu num2
            if ( num2.Text!=""&&!double.TryParse(num2.Text, out double n2))
            {
                MessageBox.Show("Vui lòng nhập số!");
                num2.Text = "";
                return;
            }
        }

        private void num3_TextChanged(object sender, EventArgs e)
        {
            //kiem tra du lieu num3
            if (num3.Text != ""&&!double.TryParse(num3.Text, out double n3))
            {
                MessageBox.Show("Vui lòng nhập số!");
                num3.Text = "";
                return;
            }
        }

        private void baitap2_Load(object sender, EventArgs e)
        {
        }

        private void Max_TextChanged(object sender, EventArgs e)
        {
        }

        private void Min_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
