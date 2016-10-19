using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CelsAndFar
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявляем переменные 
            double c; 
            //обеспечиваем ввод переменных с консоли
            Console.Write("Введите температуру в градусах Цельсия: ");
            double.TryParse(Console.ReadLine(), out c);
            //описываем функцию перевода градусов Цельсия в градусы Фаренгейта
            double f = c * 9 / 5 + 32;
            //выводим ответ на экран
            Console.WriteLine("Температура по Фаренгейту равна: {0}", f);
            //не позволяем программе вылетать сразу после вывода ответа
            Console.ReadKey();
        }
    }
}
