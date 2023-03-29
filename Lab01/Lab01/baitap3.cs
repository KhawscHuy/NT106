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
    public partial class baitap3 : Form
    {   
        //bien du lieu lam viec
        double Num;
        public baitap3()
        {
            InitializeComponent();
        }
        private void num_TextChanged(object sender, EventArgs e)
        {
            //kiem tra du lieu
            if (num.Text != "" && !double.TryParse(num.Text, out Num))
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0->9!");
                num.Text = "";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cho phep doc
            ans.ReadOnly = true;
            //kiem tra dieu kien 0->9
            if (Num<0||Num>9)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0->9!");
                num.Text = "";
                return;
            }
            //chon output cho num.text
            switch (num.Text)
            {
                case "0":
                    ans.Text = "không";
                    break;
                case "1":
                    ans.Text = "một";
                    break;
                case "2":
                    ans.Text = "hai";
                    break;
                case "3":
                    ans.Text = "ba";
                    break;
                case "4":
                    ans.Text = "bốn";
                    break;
                case "5":
                    ans.Text = "năm";
                    break;
                case "6":
                    ans.Text = "sáu";
                    break;
                case "7":
                    ans.Text = "bảy";
                    break;
                case "8":
                    ans.Text = "tám";
                    break;
                case "9":
                    ans.Text = "chín";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //xoa
            num.Text = "";
            ans.Text = "";
            return;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //thoat
            MessageBox.Show("Cám ơn đã sử dụng chương trình!!!");
            Close();
        }

        private void ans_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
