using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie5
{
    class Zadanie5
    {
        static void Main(string[] args)
        {
            int m;
            int n;
            double x;
            double result = 0;
            double rub;
            Console.WriteLine("Введите номер валюты, которую необходимо перевести:");
            Console.WriteLine("1 - доллар");
            Console.WriteLine("2 - евро");
            Console.WriteLine("3 - фунты");
            Console.WriteLine("4 - иены");
            if (int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Введите число:");
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    switch (m)
                    {
                        case 1: result = x / 63.74; break;
                        case 2: result = x / 70.45; break;
                        case 3: result = x / 79.32; break;
                        case 4: result = x / 1.62; break;
                        default: Console.WriteLine("Ошибка! Валюта с данным номером не найдена"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение! Введите число.");
                };
                rub = result;
                Console.WriteLine("Выберете в какую валюту переводить:");
                Console.WriteLine("1 - доллар");
                Console.WriteLine("2 - евро");
                Console.WriteLine("3 - фунты");
                Console.WriteLine("4 - иены");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    switch (n)
                    {
                        case 1: result = rub * 63.74; break;
                        case 2: result = rub * 70.45; break;
                        case 3: result = rub * 79.32; break;
                        case 4: result = rub * 1.62; break;
                        default: Console.WriteLine("Ошибка! Валюта с данным номером не найдена"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение! Введите целое число.");
                };
            }
            else
            {
                Console.WriteLine("Неверное значение! Введите целое число.");
            };
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
