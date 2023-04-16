using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lab2
{
    public partial class baitap1 : Form
    {
        public baitap1()
        {
            InitializeComponent();
        }

        private void baitap1_Load(object sender, EventArgs e)
        {
            rtb_Read.ReadOnly = true;
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            rtb_Read.Text= sr.ReadToEnd();
            sr.Close();
        }

        private void ReadfileRTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(rtb_Read.Text.ToUpper());
            rtb_Read.Text = "Congratulation successfully write files";
            sw.Close();
        }
    }
}
