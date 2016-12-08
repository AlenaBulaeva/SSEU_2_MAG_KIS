using System;
using System.Collections.Generic;
using System.Text;

namespace FIO
{
    class FIO
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string imya = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string otchestvo = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string familiya = Console.ReadLine();
            //И. О. Фамилия
            Console.WriteLine(imya[0] + "." + otchestvo[0] + "." + familiya);
            Console.WriteLine(imya[0].ToString().ToUpper() + "." //И.
                              + otchestvo[0].ToString().ToUpper() + "." //O.
                              + familiya[0].ToString().ToUpper() //Ф
                              + familiya.Substring(1).ToLower()); //амилия
            Console.WriteLine(familiya[0].ToString().ToUpper() //Ф
                              + familiya.Substring(1).ToLower() + "." //амилия
                              + imya[0].ToString().ToUpper() + "." //И.
                              + otchestvo[0].ToString().ToUpper());  //O.
            Console.WriteLine(imya[0].ToString().ToUpper()  //И
                              + imya.Substring(1).ToLower() + "." //мя
                              + otchestvo[0].ToString().ToUpper() //O
                              + otchestvo.Substring(1).ToLower() + "." //тчество
                              + familiya.ToUpper()); //ФАМИЛИЯ
            Console.WriteLine(familiya.Substring(0, 3) + "_"  //фам_
                              + imya.Substring(0, 1) + "_" //и_
                              + otchestvo.Substring(0, 1).ToLower()); //о
            Console.ReadKey();
        }
    }
}
