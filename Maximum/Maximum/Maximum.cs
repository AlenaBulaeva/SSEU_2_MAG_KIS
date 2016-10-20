using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {//ввод исходных значений
            int A, B;
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);
            //если больше А
            if (A >= B)
            {

            }
            //иначе - больше В
            else
            {
                //максимальное значение 
                int Max;
                //если больше А
                if (A >= B)
                {
                    Max = A;
                }
                else
                {
                    Max = B;
                };
                //вывод результата
                Console.WriteLine("Максимальное = " + Max);
                //завершение программы
                Console.ReadKey();
            }
        }
    }
}