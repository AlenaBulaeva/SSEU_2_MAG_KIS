using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfNumbers
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            int N; //количество чисел
            int x; //одно число
            Console.WriteLine("Введите колличество чисел для суммирования:");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int Sum = 0; //сумма чисел
                //N раз
                for (int i = 0; i < N; i++)
                {
                    //если введено корректное число
                    Console.WriteLine("Введите число:");
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x; //добавить к сумме
                        /* DEBUG INFO
                        Console.WriteLine("{" + Sum + "}");
                        //*/
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение! Введите целое значение!");
                        i--;
                    };
                };
                //вывод результата
                Console.WriteLine("Сумма: " + Sum);
            };
            //завершение рограммы
            Console.ReadKey();
        }
    }
}
