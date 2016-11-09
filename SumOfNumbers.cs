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
                int i = 0;
                //N раз
                while (i < N)
                {
                    Console.Write("Введите число: ");
                    //если введено корректное число
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        Sum += x; //добавить к сумме
                        /* DEBUG INFO
                        Console.WriteLine("{" + Sum + "}");
                        //*/
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение! Введите целое значение!");
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
