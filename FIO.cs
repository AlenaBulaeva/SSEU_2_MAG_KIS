using System;
using System.Collections.Generic;
using System.Text;

namespace FIO
{
    class FIO
    {
        static void Main(string[] args)
        {
            Console.Write("������� ���: ");
            string imya = Console.ReadLine();
            Console.Write("������� ��������: ");
            string otchestvo = Console.ReadLine();
            Console.Write("������� �������: ");
            string familiya = Console.ReadLine();
            //�. �. �������
            Console.WriteLine(imya[0] + "." + otchestvo[0] + "." + familiya);
            Console.WriteLine(imya[0].ToString().ToUpper() + "." //�.
                              + otchestvo[0].ToString().ToUpper() + "." //O.
                              + familiya[0].ToString().ToUpper() //�
                              + familiya.Substring(1).ToLower()); //������
            Console.WriteLine(familiya[0].ToString().ToUpper() //�
                              + familiya.Substring(1).ToLower() + "." //������
                              + imya[0].ToString().ToUpper() + "." //�.
                              + otchestvo[0].ToString().ToUpper());  //O.
            Console.WriteLine(imya[0].ToString().ToUpper()  //�
                              + imya.Substring(1).ToLower() + "." //��
                              + otchestvo[0].ToString().ToUpper() //O
                              + otchestvo.Substring(1).ToLower() + "." //�������
                              + familiya.ToUpper()); //�������
            Console.WriteLine(familiya.Substring(0, 3) + "_"  //���_
                              + imya.Substring(0, 1) + "_" //�_
                              + otchestvo.Substring(0, 1).ToLower()); //�
            Console.ReadKey();
        }
    }
}
