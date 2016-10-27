using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            //���� �������� ��������
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
            {
                //������������ ��������
                int Max = (A >= B) ? A : B;
                Max = (Max >= C) ? Max : C;
                //����� ����������
                Console.WriteLine("������������ = " + Max);
            }
            else
            {
                Console.WriteLine("�������� ��������! ����� ������ ����� �����.");
            };
            //���������� ���������
            Console.ReadKey();
        }
    }
}

