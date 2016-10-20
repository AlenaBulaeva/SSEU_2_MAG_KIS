using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод исходных значений
            int A, B;
            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {
                    //максимальное значение
                    int Max = (A >= B) ? A:B;
                    {
                    //вывод результата
                    Console.WriteLine("Максимальное = " + Max);
                    }
                    else 
                    {
                        Console.WriteLine("Неверное значение! Нужно ввести целое число.");
                    };
                }
                else
                {
                    Console.WriteLine("Неверное значение! Нужно ввести целое число.");
                };
                //завершение программы
                Console.ReadKey();
            }
        }
    }
}

