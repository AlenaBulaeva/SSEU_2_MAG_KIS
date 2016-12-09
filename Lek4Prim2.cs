using System;
using System.Collections.Generic;
using System.Text;

namespace Identificator
{
    class Lek4Prim2
    {
        static void Main(string[] args)
        {
            bool noErrors = true; //��� ������, �� ���������
            Console.WriteLine("������� �������������: ");
            string id = Console.ReadLine(); //�������������
            //�������� ������� �������
            if (!((id[0] >= 'a') && (id[0] <= 'z') // �� �������� �����
                || (id[0] >= 'A') && (id[0] <= 'Z') // ��� ��������� �����
                || (id[0] == '_'))) //��� �������������
            {
                noErrors = false;
                Console.WriteLine("������ ������ ������ ���� ��������� ������ ��� ������ �������������!");
                // �������� ��������� ��������
                for (int i = 1; i < id.Length; i++)
                {
                    //�������� i-���� �������
                    if (!((id[i] >= 'a') && (id[i] <= 'z') // �� �������� �����
                    || (id[i] >= 'A') && (id[i] <= 'Z') // ��� ��������� �����
                    || (id[i] >= '0') && (id[i] <= '9') // ��� �����
                    || (id[0] == '_'))) //��� �������������
                    {
                        noErrors = false;
                        Console.WriteLine("������ " + i + "(" + id[i] + ")" + " ������ ���� ��������� ������, ������ ��� ������ �������������!");
                    };
                };
            };
            if (noErrors)
            {
                Console.WriteLine("������������� ������.");
            };
            Console.ReadKey();
        }
    }
}
