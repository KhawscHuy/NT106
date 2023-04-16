using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Lab2
{
    public partial class baitap3 : Form
    {
        public baitap3()
        {
            InitializeComponent();
            btn_Write.Enabled = false;
            rtb_Read.ReadOnly = true;
            rtb_Write.ReadOnly = true;
        }
        StreamReader sr;
        StreamWriter sw;
        string[] lines;


        static double Evaluate(string expression)
        {

            Stack<double> operands = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (char.IsDigit(ch))
                {
                    double operand = 0;

                    while (i < expression.Length && char.IsDigit(expression[i]))
                    {
                        operand = operand * 10 + (expression[i] - '0');
                        i++;
                    }

                    operands.Push(operand);
                    i--;
                }

                else if (ch == '(')
                {
                    operators.Push(ch);
                }

                else if (ch == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        double operand2 = operands.Pop();
                        double operand1 = operands.Pop();
                        char op = operators.Pop();
                        double result = ApplyOperator(operand1, operand2, op);
                        operands.Push(result);
                    }

                    operators.Pop();
                }

                else if (IsOperator(ch))
                {
                    while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(ch))
                    {
                        double operand2 = operands.Pop();
                        double operand1 = operands.Pop();
                        char op = operators.Pop();
                        double result = ApplyOperator(operand1, operand2, op);
                        operands.Push(result);
                    }
                    operators.Push(ch);
                }
            }
            while (operators.Count > 0)
            {
                double operand2 = operands.Pop();
                double operand1 = operands.Pop();
                char op = operators.Pop();
                double result = ApplyOperator(operand1, operand2, op);
                operands.Push(result);
            }
            return operands.Pop();
        }






        static bool IsOperator(char ch)
        {
            return ch == '+' || ch == '-' || ch == '*' || ch == '/';
        }

        static int Precedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                default:
                    return 0;
            }
        }

        static double ApplyOperator(double operand1, double operand2, char op)
        {
            switch (op)
            {
                case '+':
                    return operand1 + operand2;

                case '-':
                    return operand1 - operand2;

                case '*':
                    return operand1 * operand2;

                case '/':
                    return operand1 / operand2;

                default:
                    throw new ArgumentException($"Invalid operator: {op}");
            }
        }





        private void btn_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            lines = File.ReadAllLines(ofd.FileName);
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            sr = new StreamReader(fs);
            rtb_Read.Text = sr.ReadToEnd();
            btn_Write.Enabled = true;
        }
        private void btn_Write_Click(object sender, EventArgs e)
        {
            btn_Read.Enabled = false;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.Append);
            sw = new StreamWriter(fs);
            foreach (string line in lines)
            {
                double result = Evaluate(line);
                rtb_Write.Text+=line + "=" + result.ToString();
                rtb_Write.Text += "\n";
            }
            MessageBox.Show("Congratulation! Write successfully....");
            sw.Write(rtb_Write.Text);
            sw.Close();
        }
    }
}
