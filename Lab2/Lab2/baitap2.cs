using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class baitap2 : Form
    {
        public baitap2()
        {
            InitializeComponent();
        }
        
     
        
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        int ReadWord(string text)
        {
            Regex regex = new Regex(@"\w+");
            MatchCollection matches = regex.Matches(text);
            return matches.Count;
        }
        private void btn_readfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            ReadfileRTB.Text = sr.ReadToEnd();
            tb_FileName.Text = ofd.SafeFileName.ToString();
            tb_Size.Text = fs.Length.ToString() + " bytes";
            tb_URL.Text = fs.Name.ToString();
            tb_LineCount.Text = ReadfileRTB.Lines.Count().ToString();
            tb_WordsCount.Text = ReadWord(ReadfileRTB.Text).ToString();
            tb_CharCount.Text=ReadfileRTB.Text.Length.ToString();
            sr.Close();
        }

        private void ReadfileRTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
