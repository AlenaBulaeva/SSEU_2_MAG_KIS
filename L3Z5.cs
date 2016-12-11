using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek3Zad5
{
    class L3Z5
    {
        static void Main()
        {
            Sort();
        }

        /*Основная программа*/
        static void Sort()
        {
            //ввод длины массива
            int n;
            do
            {
                Console.Write("Введите длину массива: ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            //инициализация массива
            int[] myint = new int[n];
            //ввод значений массива
            int i = 0;
            while (i < n)
            {
                Console.Write("Введите а[" + i + "]:");
                if (int.TryParse(Console.ReadLine(), out myint[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число!");
                };
            };

            WriteArray(myint);
            ShakerSort(myint);
            WriteArray(myint);

            Console.ReadLine();
        }

        /* Шейкер-сортировка */
        static void ShakerSort(int[] myint)
        {
            int left = 0,
                right = myint.Length - 1,
                count = 0;
            string vibor;
            //выбираем операцию
            Console.Write("\n\nВыберите направление сортировки 1 - по возрастанию или 2 - по убыванию: ");
            vibor = Console.ReadLine();
            switch (vibor)
            {
                case "1":
                    while (left <= right)
                    {
                        for (int i = left; i < right; i++)
                        {
                            count++;
                            if (myint[i] > myint[i + 1])
                                Swap(myint, i, i + 1);
                        }
                        right--;
                        for (int i = right; i > left; i--)
                        {
                            count++;
                            if (myint[i - 1] > myint[i])
                                Swap(myint, i - 1, i);
                        }
                        left++;
                    }
                    Console.WriteLine("\nКоличество сравнений = {0}", count.ToString());
                    break;
                case "2":
                    while (left <= right)
                    {
                        for (int i = left; i < right; i++)
                        {
                            count++;
                            if (myint[i] < myint[i + 1])
                                Swap(myint, i, i + 1);
                        }
                        right--;
                        for (int i = right; i > left; i--)
                        {
                            count++;
                            if (myint[i - 1] < myint[i])
                                Swap(myint, i - 1, i);
                        }
                        left++;
                    }
                    Console.WriteLine("\nКоличество сравнений = {0}", count.ToString());
                    break;
                default: Console.WriteLine("Неверная операция"); break;
            };
        }

        /* Поменять элементы местами */
        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }

        /*Вывести массив*/
        static void WriteArray(int[] a)
        {
            foreach (int i in a)
                Console.Write("{0}|", i.ToString());
            Console.Write("");
        }
    }
}
