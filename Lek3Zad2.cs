using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3Zad2
{
    class Lek3Zad2
    {
        static void Main(string[] args)
        {
            int col = 0;
            int sum = 0;
            int j;
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out j))
            {
                do
                {
                    sum += j % 10;
                    col++;
                    j = j / 10;
                }
                while (j / 10 != 0);
                sum += j;
                col++;
            }
            else
            {
                Console.WriteLine("Введите целое число!");
            };
            Console.WriteLine("Cумма: " + sum);
            Console.WriteLine("Количество: " + col);
            Console.ReadKey();
        }
    }
}
