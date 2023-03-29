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
    public partial class baitap4 : Form
    {
        //bien toan cuc
        long Num;
        public baitap4()
        {
            InitializeComponent();
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //kiem tra dieu kien
            if (num.Text != "" && !long.TryParse(num.Text, out Num))
            {
                MessageBox.Show("Vui lòng nhập số !");
                num.Text = "";
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //khoi tao ty gia
            long tygia=0;
            //lua chon loai tien te
            switch (choose.Text)
            {
                case "USD":
                    tygia = 22772;
                    break;
                case "EUR":
                    tygia = 28132;
                    break;
                case "GBP":
                    tygia = 31538;
                    break;
                case "SGD":
                    tygia = 17286;
                    break;
                case "JPY":
                    tygia = 214;
                    break;
            }
            //xuat ra text box
            ans.Text = (Num * tygia).ToString();
            this.tygia.Text = "1"+ choose.Text + " = " + (tygia).ToString() + " VND";
        }

        private void ans_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
