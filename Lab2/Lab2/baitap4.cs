using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace Lab2
{
    public partial class baitap4 : Form
    {
        public baitap4()
        {
            InitializeComponent();
        }
        [Serializable]
        class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public float Grade1 { get; set; }
            public float Grade2 { get; set; }
            public float Grade3 { get; set; }
            public float Average { get; set; }
        }
        float Score1In;
        float Score2In;
        float Score3In;
        List<Student> danhSachSinhVien = new List<Student>();
        StreamReader sr;
        StreamWriter sw;
        string[] Lines;
        int iPage;
        List<Student> studentsFromFile;
        private void baitap4_Load(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            btn_Write.Enabled = false;
            btn_Next.Enabled = false;
            btn_Back.Enabled = false;
            labl_PageNumber.Text = "";
        }
        bool check()
        {

            //constraint cho Phone
            string Cons_PhoneIn = txt_PhoneIn.Text;
            if (txt_PhoneIn.Text != "" && !int.TryParse(txt_PhoneIn.Text, out int PhoneIn) && txt_PhoneIn.Text.Length != 10 &&  Cons_PhoneIn[0] != '0')
            {
                MessageBox.Show("Vui lòng nhập số điện thoại có 10 chữ số và chữ số đầu tiên là số 0");
                txt_PhoneIn.Text = "";
                return false;
            }
            //constraint cho ID
            if (txt_IDIn.Text != "" && !int.TryParse(txt_IDIn.Text, out int IDIn) || int.Parse(txt_IDIn.Text) < 10000000 || int.Parse(txt_IDIn.Text) > 99999999)
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên có 8 chữ số!");
                txt_IDIn.Text = "";
                return false;
            }
            return true;
        }
        private void txt_IDIn_TextChanged(object sender, EventArgs e)
        { 
           
        }

        private void txt_PhoneIn_TextChanged(object sender, EventArgs e)
        {
            
        }


        static void QuickSort(List<Student> studentList, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(studentList, left, right);
                QuickSort(studentList, left, pivotIndex - 1);
                QuickSort(studentList, pivotIndex + 1, right);
            }
        }

        static int Partition(List<Student> studentList, int left, int right)
        {
            int pivotIndex = left;
            int pivotValue = studentList[pivotIndex].ID;

            Swap(studentList, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (studentList[i].ID < pivotValue)
                {
                    Swap(studentList, i, storeIndex);
                    storeIndex++;
                }
            }

            Swap(studentList, storeIndex, right);

            return storeIndex;
        }

        static void Swap(List<Student> studentList, int index1, int index2)
        {
            Student temp = studentList[index1];
            studentList[index1] = studentList[index2];
            studentList[index2] = temp;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if(
                    txt_NameIn.Text == ""||
                    txt_IDIn.Text == ""||
                    txt_PhoneIn.Text == ""||
                    txt_Course1In.Text == ""||
                    txt_Course2In.Text == ""||
                    txt_Course3In.Text == ""||
                    txt_AverageIn.Text == ""
              )
            {
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm 1 sinh viên!!!", "Information Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //chuan hoa ho ten
            if (!string.IsNullOrEmpty(txt_NameIn.Text))
            {
                txt_NameIn.Text = txt_NameIn.Text.ToLower();
                txt_NameIn.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_NameIn.Text);
            }
            if (check())
            {
                Student student = new Student
                {
                    Name = txt_NameIn.Text,
                    ID = int.Parse(txt_IDIn.Text),
                    Phone = txt_PhoneIn.Text,
                    Grade1 = float.Parse(txt_Course1In.Text),
                    Grade2 = float.Parse(txt_Course2In.Text),
                    Grade3 = float.Parse(txt_Course3In.Text),
                    Average = float.Parse(txt_AverageIn.Text)
                };
                rtb_Write.Text += "Name: " + txt_NameIn.Text + "\n";
                rtb_Write.Text += "ID: " + txt_IDIn.Text + "\n";
                rtb_Write.Text += "Phone: " + txt_PhoneIn.Text + "\n";
                rtb_Write.Text += "Score 1: " + txt_Course1In.Text + "\n";
                rtb_Write.Text += "Score 2: " + txt_Course2In.Text + "\n";
                rtb_Write.Text += "Score 3: " + txt_Course3In.Text + "\n";
                rtb_Write.Text += "Average Score: " + txt_AverageIn.Text + "\n\n";
                if (!btn_Write.Enabled)
                {
                    MessageBox.Show("Thêm thành công! Giờ bạn có thể ghi vào file!");
                }
                danhSachSinhVien.Add(student);
                QuickSort(danhSachSinhVien, 0, danhSachSinhVien.Count - 1);
                btn_Write.Enabled = true;
            }
            else
            {
                return;
            }
            txt_NameIn.Text = "";
            txt_IDIn.Text = "";
            txt_PhoneIn.Text = "";
            txt_Course1In.Text = "";
            txt_Course2In.Text = "";
            txt_Course3In.Text = "";
            txt_AverageIn.Text = "";

        }

        private void NewMethod()
        {
            rtb_Write.Text += txt_PhoneIn.Text + "\n";
        }

        private void txt_Course1In_TextChanged(object sender, EventArgs e)
        {
            
            if (!float.TryParse(txt_Course1In.Text, out Score1In)&&txt_Course1In.Text!="")
            {
                MessageBox.Show("Vui lòng nhập điểm là một số!");
                txt_Course1In.Text = "";
                txt_Course1In.Focus();
                return;
            }
            if ( Score1In > 10&& txt_Course1In.Text != "")
            {
                MessageBox.Show("Vui lòng nhập điểm từ 0 -> 10!");
                txt_Course1In.Text = "";
                txt_Course1In.Focus();
                return;
            }

            txt_AverageIn.Text = ((Score1In + Score2In + Score3In) / 3.0f).ToString();
        }

        private void txt_Course2In_TextChanged(object sender, EventArgs e)
        {
        
            if (!float.TryParse(txt_Course2In.Text, out Score2In) && txt_Course2In.Text != "")
            {
                MessageBox.Show("Vui lòng nhập điểm là một số!");
                txt_Course2In.Text = "";
                txt_Course2In.Focus();
                return;
            }
            if (Score2In > 10 && txt_Course2In.Text != "")
            {
                MessageBox.Show("Vui lòng nhập điểm từ 0 -> 10!");
                txt_Course2In.Text = "";
                txt_Course2In.Focus();
                return;
            }

            txt_AverageIn.Text = ((Score1In + Score2In + Score3In) / 3.0f).ToString();
        }

        private void txt_Course3In_TextChanged(object sender, EventArgs e)
        {    
            if (!float.TryParse(txt_Course3In.Text, out Score3In) && txt_Course3In.Text != "")
            {
                MessageBox.Show("Vui lòng nhập điểm là một số!");
                txt_Course3In.Text = "";
                txt_Course3In.Focus();
                return;
            }
            if (Score3In > 10 && txt_Course3In.Text != "")
            {
                MessageBox.Show("Vui lòng nhập điểm từ 0 -> 10!");
                txt_Course3In.Text = "";
                txt_Course3In.Focus();
                return;
            }

            txt_AverageIn.Text = ((Score1In + Score2In + Score3In) / 3.0f).ToString();
        }
        private void txt_AverageIn_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            btn_Read.Enabled = false;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            sw = new StreamWriter(fs);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, danhSachSinhVien);
            rtb_Write.Text = "";
            MessageBox.Show("Ghi thành công....");
            sw.Close();
            btn_Read.Enabled = true;
        }
        void Output(Student student)
        {
            if(student != null)
            {
                txt_NameOut.Text = student.Name;
                txt_IDOut.Text = student.ID.ToString();
                txt_PhoneOut.Text = student.Phone;
                txt_Course1Out.Text = student.Grade1.ToString();
                txt_Course2Out.Text = student.Grade2.ToString();
                txt_Course3Out.Text = student.Grade3.ToString();
                txt_AverageOut.Text = student.Average.ToString();
            }
            labl_PageNumber.Text = (iPage + 1).ToString();
        }
        private void btn_Read_Click(object sender, EventArgs e)
        {
            iPage = 0;
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            sr = new StreamReader(fs);
            BinaryFormatter formatter = new BinaryFormatter();
            studentsFromFile = (List<Student>)formatter.Deserialize(fs);
            Output(studentsFromFile[iPage]);
            btn_Back.Enabled = false;
            btn_Next.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            iPage--;
            if (iPage == 0)
            {
                btn_Back.Enabled = false;
            }
            btn_Next.Enabled = true;
            Output(studentsFromFile[iPage]);
        }

        private void labl_PageNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            iPage++;
            if (iPage == studentsFromFile.Count-1)
            {
                btn_Next.Enabled = false;
            }
            btn_Back.Enabled = true;
            Output(studentsFromFile[iPage]);
        }
    }
}
