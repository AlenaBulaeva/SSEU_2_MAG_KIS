using System;
using System.Collections.Generic;
using System.Text;

namespace Primer4
{
    class Primer4
    {
        static void Main(string[] args)
        {
            double operand1, operand2 = 0; //��������
            double result = 0; //��������� ����������
            string operation; //��������
            Console.WriteLine("������� �����: ");
            if (double.TryParse(Console.ReadLine(), out operand1))
            {
                //�������� ��������
                Console.WriteLine("�������� ��������: ");
                Console.WriteLine("+ - ��������");
                Console.WriteLine("- - ���������");
                Console.WriteLine("* - ���������");
                Console.WriteLine("/ - �������");
                Console.WriteLine("sqrt - ������ �� �����");
                operation = Console.ReadLine();
                switch (operation)
                {
                    //�������� � ����� ����������
                    case "+": 
                    case "-": 
                    case "*": 
                    case "/": 
                        //��������� ������ �������
                        Console.WriteLine("������� ������ ��������: ");
                        if (double.TryParse(Console.ReadLine(), out operand2))
                        {
                            //����� ������ ��������?
                            switch (operation)
                            {
                                case "+": result = operand1 + operand2; break;
                                case "-": result = operand1 - operand2; break;
                                case "*": result = operand1 * operand2; break;
                                case "/": result = operand1 / operand2; break;
                            };
                        }
                        else
                        {
                            Console.WriteLine("������� ������ ���� ������!");
                        };
                        break;
                        //�������� � ����� ���������
                    case "sqrt": result = Math.Sqrt(operand1); break;
                        //������������ ��������
                    default: Console.WriteLine("�������� ��������!"); break;
                };
                //������� ���������
                Console.WriteLine("���������: ");
                Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + result);
            }
            else
            {
                Console.WriteLine("������� ������ ���� ������!");
            };
            Console.ReadKey();
        }
    }
}
        