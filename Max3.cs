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
                int Max;
                //���� � >= B
                if (A >= B)
                {
                    //� ���� � >= �
                    if (A >= C)
                    {
                        //�� ������������ - �
                        Max = A;
                    }
                    //����� - C > A
                    else
                    {
                        //������������ - �
                        Max = C;
                    }
                }
                //����� - ������ �
                else
                {
                    // � ���� B >= C
                    if (B >= C)
                    {
                        //�� ������������ �
                        Max = B;
                    }
                    // ����� - � > �
                    else
                    {
                        // ������������ - �
                        Max = C;
                    }
                };
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