using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc2
{
    class ConsoleCalc2
    {//���� �������� � ������� � ��������� ��������
        static double ReadOperand()
        {
            double operand = 0;   //�������� ��������
            Console.Write("������� �����: ");
            //��������� ����, ���� �� ����� ������� ���������� ��������
            while (!double.TryParse(Console.ReadLine(), out operand))
            {
                Console.Write("�������� ��������! ������� �����: ");
            };
            //������� ��������
            return operand;
        }
        static void Main(string[] args)
        {
            //������ �������
            double operand1 = ReadOperand();
            //������ �������
            double operand2;
            //��������
            string operation;
            do
            {
                //�������� ��������
                Console.WriteLine("+ - ��������");
                Console.WriteLine("- - ���������");
                Console.WriteLine("* - ���������");
                Console.WriteLine("/ - �������");
                Console.WriteLine("sqrt - ������ �� �����");
                Console.Write("�������� ��������: ");
                operation = Console.ReadLine();
                operation = operation.ToLower();
                switch (operation)
                {
                    //�������� � ����� ����������
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        //��������� ������ �������
                       operand2 = ReadOperand();
                            //����� ������ ��������?
                            switch (operation)
                            {
                                case "+": operand1 = operand1 + operand2; break;
                                case "-": operand1 = operand1 - operand2; break;
                                case "*": operand1 = operand1 * operand2; break;
                                case "/": operand1 = operand1 / operand2; break;
                            };
                        break;
                    //�������� � ����� ���������
                    case "sqrt": operand1 = Math.Sqrt(operand1); break;
                    //����� �� ���������
                    case "quit": case "exit": return;
                    //������������ ��������
                    default: Console.WriteLine("�������� ��������!"); break;
                };
                //������� ���������
                Console.WriteLine("���������: " + operand1);
                Console.WriteLine("��� ������ �������� quit ��� exit");
            }
            //���� �� ����� ������� ������� ������
            while (!((operation == "quit") || (operation == "exit")));
        }
    }
}
