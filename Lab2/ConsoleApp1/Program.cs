using System;
using System.Collections.Generic;
using System.IO;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đọc dữ liệu từ file "input3.txt"
            string[] lines = File.ReadAllLines("input3.txt");

            // Duyệt qua từng dòng để thực hiện phép tính và ghi kết quả xuống file "output3.txt"
            StreamWriter writer = new StreamWriter("output3.txt");
            foreach (string line in lines)
            {
                    double result = Evaluate(line);
                    writer.WriteLine($"{line} = {result}");
            }
        }

        static double Evaluate(string expression)
        {
            // Sử dụng ngăn xếp để lưu các toán hạng và toán tử
            Stack<double> operands = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            // Duyệt qua từng ký tự trong biểu thức
            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                // Nếu ký tự là một chữ số, đưa nó vào ngăn xếp toán hạng
                if (char.IsDigit(ch))
                {
                    double operand = 0;

                    // Đọc các chữ số liên tiếp cho đến khi gặp ký tự không phải chữ số
                    while (i < expression.Length && char.IsDigit(expression[i]))
                    {
                        operand = operand * 10 + (expression[i] - '0');
                        i++;
                    }

                    operands.Push(operand);
                    i--;
                }

                // Nếu ký tự là dấu ngoặc trái, đưa nó vào ngăn xếp toán tử
                else if (ch == '(')
                {
                    operators.Push(ch);
                }

                // Nếu ký tự là dấu ngoặc phải, thực hiện các phép tính trong ngoặc đơn
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

                // Nếu ký tự là một toán tử, đưa nó vào ngăn xếp toán tử và thực hiện các phép tính
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

            // Thực hiện các phép tính còn lại trong ngăn xếp
            while (operators.Count > 0)
            {
                double operand2 = operands.Pop();
                double operand1 = operands.Pop();
                char op = operators.Pop();
                double result = ApplyOperator(operand1, operand2, op);
                operands.Push(result);
            }
            // Kết quả cuối cùng là toàn bộ phần tử còn lại trong ngăn xếp toán hạng
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
    }
}