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
            string otchestvoSokr;
            //И. О. Фамилия
            if (!string.IsNullOrEmpty(otchestvo)) //если ввели отчество
            {
                otchestvoSokr = otchestvo[0].ToString().ToUpper() + ". "; //то делаем сокращение
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
            }
            else //иначе - отчество не ввели
            {
                otchestvoSokr = ""; // его сокращение - пустая строка
                //выводим без отчества
                Console.WriteLine(imya[0].ToString().ToUpper() + "." //И.
                                  + familiya[0].ToString().ToUpper() //Ф
                                  + familiya.Substring(1).ToLower()); //амилия
                Console.WriteLine(familiya[0].ToString().ToUpper() //Ф
                              + familiya.Substring(1).ToLower() + "." //амилия
                              + imya[0].ToString().ToUpper()); //И.
                Console.WriteLine(imya[0].ToString().ToUpper()  //И
                             + imya.Substring(1).ToLower() + "." //мя
                             + familiya.ToUpper()); //ФАМИЛИЯ
                Console.WriteLine(familiya.Substring(0, 3) + "_"  //фам_
                              + imya.Substring(0, 1)); //и_
            };
            Console.ReadKey();
        }
    }
}
