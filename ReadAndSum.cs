using System;
using System.Collections.Generic;
using System.Text;

namespace ReadAndSum
{
    class Program
    {
        static void Main(string[] args)
        {//объявляем переменные 
            int a; 
            int b;
            //обеспечиваем ввод переменных с консоли
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            //определяем функцию сложения
            int sum = a + b;
            //выводим на экран значение а, b и их сумму
            Console.WriteLine(a + "+" + b + "=" + sum);
            //чтобы система не вылетала
            Console.ReadKey();
        }
    }
}
