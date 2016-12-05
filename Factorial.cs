using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie1_Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int N; //количество чисел
            int i = 1;
            int fuct = 1;
            Console.WriteLine("Введите колличество чисел для вычисления факториала:");
            if (int.TryParse(Console.ReadLine(), out N))
            while(i < N + 1)
            {            
                    //факториал числа
                    fuct = fuct * i; 
                    Console.WriteLine("{" + fuct + "}");
                    i++;
            };
            //вывод результата
            Console.WriteLine("Факториал: " + fuct);
            //завершение рограммы
            Console.ReadKey();
        }
    }
}
