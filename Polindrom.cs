using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4Zad2
{
    class Polindrom
    {
        static void Main(string[] args)
        {
            //ввод данных для проверки
            Console.Write("Введите слово или фразу для проверки: ");
            string S = Console.ReadLine(); 
            S = S.ToLower(); //переводим строку в нижний регистр
            S = S.Replace(" ", ""); //удаляем пробелы
            char[] a = S.ToCharArray(); //переводим текст из строкового типа в символьный чтобы сравнить
            Array.Reverse(a); //переворачиваем символы
            string P = new string(a);
            //сравниваем введенную строку с перевернутой
            if (S == P) //если равны
            {
                Console.WriteLine("Введенное слово(фраза) является палиндромом!"); 
            }
            else if (S != P) //если не равны
            {
                Console.WriteLine("Введенное слово(фраза) не является палиндромом!");
            }
            Console.ReadKey();
        }
    }
}
