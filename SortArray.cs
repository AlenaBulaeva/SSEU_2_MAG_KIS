using System;
using System.Collections.Generic;
using System.Text;

namespace SortArray
{
    class SortArray
    {
        static void Main(string[] args)
        {
            //ввод длины массива
            int n;
            do
            {
                Console.Write("¬ведите длину массива: ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            //инициализаци€ массива
            int[] a = new int[n];
            //ввод значений массива
            int i = 0;
            while (i < n)
            {
                Console.Write("¬ведите а[" + i + "]:");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("¬ведите целое число!");
                };
            };
            //сортировка массива
            for (i = 0; i < a.Length - 1; i++)
            {
                for (int j = 1; j < a.Length - i; j++)
                {
                    //если предыдущий элемент больше текущего, помен€ть их местами
                    if (a[j - 1] >= a[j])
                    {
                        int buf = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = buf;
                    };
                };
            };
            //вывод отсортированного массива
            Console.WriteLine("ќтсортированный массив:");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            };
            Console.ReadKey();
        }
    }
}
