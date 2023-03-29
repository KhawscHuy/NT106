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
    
    public partial class baitap5 : Form
    {
        public baitap5()
        {
            InitializeComponent();
        }
        ulong a;
        ulong b;
        private void A_TextChanged(object sender, EventArgs e)
        {
            if (A.Text != "" && !ulong.TryParse(A.Text, out a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                A.Text = "";
                return;
            }
        }
        //tinh giai thua
        ulong giai_thua(ulong a)
        {   
            if (a == 0) return 1;
            return a*giai_thua(a-1);
        }
        //tinh tong tu 1 den a
        ulong tong(ulong a,ulong i = 1)
        {
            if (i == a) return a;
            return i+tong(a, i+1);
        }
        //tinh so mu a^b
        double mu(double a,ulong b)
        {
            if (b == 0) return 1;
            return a*mu(a,b-1);
        }
        //tinh tong mu tu a^1->a^b
        double tong_mu(double a, ulong b,ulong i = 1)
        {
            if (i == b) return mu(a, b);
            return mu(a,i)+tong_mu(a,b,i+1);
        }
        private void ans_Click(object sender, EventArgs e)
        {
            //chuyen doi du lieu
            ulong.TryParse(A.Text, out ulong a);           
            ulong.TryParse(B.Text, out ulong b);
            //cho phep doc
            ans1.ReadOnly = true;
            ans2.ReadOnly = true;
            ans3.ReadOnly = true;
            ans4.ReadOnly = true;
            ans5.ReadOnly = true;
            //xuat ra text box
            ans1.Text = "A! = " + (giai_thua(a).ToString());
            ans2.Text = "B! = " + (giai_thua(b).ToString());
            ans3.Text = "S1 = 1 + 2 + 3 + 4 +...+ A = " + (tong(a).ToString());
            ans4.Text = "S2 = 1 + 2 + 3 + 4 +...+ B = " + (tong(b).ToString());
            ans5.Text = "S3 = A^1 + A^2 + A^3 + A^4 +...+ A^B = " + (tong_mu(a,b).ToString());
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            //xoa
            A.Text = "";
            B.Text = "";    
            ans1.Text = "";
            ans2.Text = "";
            ans3.Text = "";
            ans4.Text = "";
            ans5.Text = "";
            return;
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            //thoat
            MessageBox.Show("Cám ơn đã sử dụng chương trình!!!");
            Close();
        }

        private void B_TextChanged(object sender, EventArgs e)
        {
            if (B.Text != "" && !ulong.TryParse(B.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                B.Text = "";
                return;
            }
        }
    }
}
