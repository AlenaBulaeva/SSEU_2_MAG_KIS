using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявляем переменные 
            int a=19; 
            int b=5;
			int c=1993;
			double x;
            //обеспечиваем ввод переменных с консоли
			Console.Write("Введите значение X: ");
            double.TryParse(Console.ReadLine(), out x);
            //определяем функцию
            double fun = -(x/a*Math.Sqrt(Math.Pow(x, 2)+b*x))+c;
            //выводим на экран значение функции при заданных значениях
            Console.WriteLine("F(x)" + "=" + fun);
            //чтобы система не вылетала
            Console.ReadKey();
        }
    }
}