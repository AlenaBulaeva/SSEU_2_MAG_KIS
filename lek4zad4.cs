using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4Zad4
{
    class lek4zad4
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово для проверки: ");
            string S = Console.ReadLine(); 
            int k = 0; 
            char ps = ' '; // предыдущий символ
            foreach (char s in S) //задаем опорный символ
            {
                foreach (char sa in S) // проверяем все символы
                    if (sa != ps && sa == s) //если символ не равен предыдущему символу и равен опорному символу
                        k++; // то увеличиваем количество на 1
                if (k != 0) // если количество не равно 0
                    Console.Write("{0}{1}", s, k); // то выводим опорный символ и его количество в строке
                k = 0; 
                ps = s; // записываем в переменную предыдущего символа текущий опорный символ
            }
            Console.ReadKey(); 
        }
    }
}
