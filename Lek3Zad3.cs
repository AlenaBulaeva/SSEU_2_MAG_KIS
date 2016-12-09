using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод длины массива
            int n;
            do
            {
                Console.Write("Введите длину массива: ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            //инициализация массива
            int[] a = new int[n];
            //ввод значений массива
            //поиск минимального значения
            int i = 0;
            while (i < n)
            {
                Console.Write("Введите а[" + i + "]:");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число!");
                };
            };
            //поиск минимального значени
            int min = a[0];
            string iMin = "0";
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == min)
                {
                    iMin = iMin + "," + i;
                    a[i] = 0;

                }
                else if (a[i] < min)
                {
                    min = a[i];
                
                };
            };
            //вывод результата
            Console.WriteLine("Минимальное значение a[" + iMin + "] = " + min);
            for (i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            };
            Console.ReadKey();
        }
    }
}
