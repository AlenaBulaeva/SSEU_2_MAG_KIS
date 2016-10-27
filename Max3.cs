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
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
            {
                //максимальное значение
                int Max;
                //если А больше остальных
                if ((A >= B)&&(A >= C))
                {
                    //то максимальное - А
                    Max = A;
                }
                    //иначе, если В больше остальных
                else if ((B >= A) && (B >= C))
                {
                    Max = B;
                }
                //иначе - остается C
                else
                {
                    Max = C;
                };
                //вывод результата
                Console.WriteLine("Максимальное = " + Max);
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