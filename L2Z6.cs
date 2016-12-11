using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek2Zad6
{
    class L2Z6
    {
        static void Main(string[] args)
        {
            double summa; //сумма кредита
            double procent = 0; //процент выплат
            double vipl = 0; //сумма выплат
            int srok, stavka, chastota; //Срок кредитования, годоавя процентная ставка и частота выплат в год
            int god = 12; //12 месяцев
            double result = 0; //результат вычисления
            double pr = 0.01; // для перевода процентов
            string operation; //метод начисления

            //ввод данных
            Console.WriteLine("Введите сумму кредитования: ");
            double.TryParse(Console.ReadLine(), out summa);
            Console.WriteLine("Введите срок кредитования: ");
            int.TryParse(Console.ReadLine(), out srok);
            Console.WriteLine("Введите ставку кредитования: ");
            int.TryParse(Console.ReadLine(), out stavka);
            Console.WriteLine("Введите количество выплат в год: ");
            int.TryParse(Console.ReadLine(), out chastota);
            
            //выбираем операцию
            Console.WriteLine("Выберите метод 1 - простой или 2 - сложный: ");
            operation = Console.ReadLine();
            switch (operation)
            {
                case "1": 
                    result = summa * (1 + (srok / god) * (stavka * pr)); //итоговая сумма выплат по кредиту
                    procent = result - summa; //сумма начисленных процентов
                    vipl = result / (srok / god) / chastota; //величина эквивалентных выплат
                    break;
                case "2": 
                    result = summa * Math.Pow(1 + stavka * pr, srok / god); //итоговая сумма выплат по кредиту
                    procent = result - summa; //сумма начисленных процентов
                    vipl = result / (srok / god) / chastota; //величина эквивалентных выплат
                    break;
                default: Console.WriteLine("Неверная операция"); break;
            };
            
            //выводим результат
            Console.WriteLine("Итоговая сумма выплат по кредиту: " + result);
            Console.WriteLine("Cумма начисленных процентов: " + procent);
            Console.WriteLine("Величина эквивалентных выплат: " + vipl);
            Console.ReadLine();
        }
    }
}

