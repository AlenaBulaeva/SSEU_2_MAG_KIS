using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skidka
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод суммы покупки
            int Sum;
            if (int.TryParse(Console.ReadLine(), out Sum))
            {
                //если сумма больше 1000
                if (Sum >= 1000)
                {
                    Sum = Sum - (Sum * 15 / 100);
                }
                //если сумма меньше 1000
                else
                {
                    Console.WriteLine("Скидка не предоставляется!");
                };
                //вывод результата
                Console.WriteLine("Сумма покупок = " + Sum);
            }
            else
            {
                Console.WriteLine("Неверное значение! Нужно ввести число.");
            };
            //завершение программы
            Console.ReadKey();
        }
    }
}