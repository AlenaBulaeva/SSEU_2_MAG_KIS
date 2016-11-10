using System;
using System.Collections.Generic;
using System.Text;

namespace SumMas
{
    class SumMas
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("¬ведите значение: ");  
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];             
            }
            Console.WriteLine("—умма: " + sum);
            Console.ReadKey();
        }
    }
}
