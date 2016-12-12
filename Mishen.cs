using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mishen
{
    class Mishen
    {
        static double ReadCoord()
        {
            // ввод координат
            double coord;
            Console.Write("Введите координату: ");
            //повторять ввод, до верного значения
            while (!double.TryParse(Console.ReadLine(), out coord))
            {
                Console.Write("Ошибка! Введите число: ");
            };
            return coord;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество выстрелов: ");
            int k; //количество выстрелов
            double summa = 0; //суммарное колечество баллов
            int.TryParse(Console.ReadLine(), out k); //ввод колличества выстрелов с клавиатуры
            double[] X = new double[k]; //массив x координат 
            double[] Y = new double[k]; //массив y координат 
            double[] R = new double[k]; //массив радиусов
            double[] a = new double[k]; //массив очков
            
            for (int i = 0 ; i < k ; ++i)
            {
                double b = 0; //вспомогательный массив для записи баллов
                double x; //координата х
                x = ReadCoord(); 
                double y; //координата у
                y = ReadCoord();
                X[i] = x;
                Y[i] = y;

                if (x * x + y * y <= 25) // если координаты меньше кругa c R = 5
                { 
                    b = 100; //то присуждается 100 баллов
                    R[i] = x * x + y * y; 
                }
                if ((x * x + y * y > 25) && (x * x + y * y <= 100)) // если координаты меньше кругa c R = 5, но больше круга с R = 10
                {
                    b = 50; //то присуждается 50 баллов
                    R[i] = x * x + y * y;
                }
                if ((x * x + y * y > 100) && (x * x + y * y <= 225)) //если координаты меньше кругa c R = 10, но больше круга с R = 15
                {
                    b = 20; //то присуждается 20 баллов
                    R[i] = x * x + y * y;
                }
                if ((x * x + y * y > 225) && (x * x + y * y <= 625)) //если координаты меньше S кругa c R = 15, но больше S круга с R = 25
                {
                    b = 10; //то присуждается 10 баллов
                    R[i] = x * x + y * y;
                }
                if ((x * x + y * y) == 900) //если координаты равны окружности c R = 30 
                {
                    b = 5; //то присуждается 5 баллов
                    R[i] = x * x + y * y;
                }
                if (x * x + y * y > 625) //координаты находятся за пределами мишени, баллы не присуждаются
                {
                    Console.WriteLine("Промах!" + "\n");
                    b = 0;
                    R[i] = x * x + y * y;
                }
                Console.WriteLine("Набрано очков за выстрел: " + b + "\n");
                a[i] = b;
                summa = summa + b;
            }

            // проверяем какой из выстрелов ближе к центру
            double min = R[0];
            for (int i = 0; i < k; ++i)
            {
                if (R[i] < min)
                {
                    min = R[i];
                }
            }
            Console.Clear();
            //выводим таблицу выстрелов
            Console.WriteLine("\t\t╔════════════╗════════════╔════════════════╗");
            Console.WriteLine("\t\t║ № выстрела ║ координаты ║ набранные очки ║");
            Console.WriteLine("\t\t╚════════════╝════════════╚════════════════╝");
            for (int i = 0; i < k; ++i)
            {
                Console.WriteLine("\t\t║      " + (i + 1) + "     ║   " + X[i] + " и " + Y[i] + "    ║       " + a[i] + "      ║\n");
                Console.WriteLine("\t\t╚════════════╝════════════╚════════════════╝");
            }
            Console.WriteLine("Сумма очков набранных за " + k + " выстрелa(ов): " + summa);
            Console.Write("Самый меткий выстрел имеет радиус " + min);
            for (int i = 0; i < k; ++i)
            {
                if (min == X[i] * X[i] + Y[i] * Y[i])
                {
                    Console.Write(" и координаты " + X[i] + " и " + Y[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
