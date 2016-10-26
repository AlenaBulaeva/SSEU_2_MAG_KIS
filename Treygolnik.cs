using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Treygolnik
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод исходных значений
            double A, B, C;
            if (double.TryParse(Console.ReadLine(), out A) && double.TryParse(Console.ReadLine(), out B) && double.TryParse(Console.ReadLine(), out C))
            {
                //проверяем треугольник на вырожденность
                if (A + B >= C && A + C >= B && B + C >= A)
                {
                    //проверяем является ли треугольник равнобедренным
                    if (A == C || A == B || B == C)
                    {
                        //то треугольник равнобедренный
                        Console.WriteLine("Треугольник равнобедренный");
                    }
                    //иначе - треугольник не равнобедренный
                    else
                    {
                        Console.WriteLine("Треугольник не равнобедренный");
                    }
                    //проверяем является ли треугольник равносторонним
                    if (A == B && B == C)
                    {
                        //то треугольник равносторонний
                        Console.WriteLine("Треугольник равносторонний");
                    }
                    //иначе - треугольник не равносторонний
                    else
                    {
                        Console.WriteLine("Треугольник не равносторонний");
                    }
                    //записываем формулы для нахождения периметра и площади треугольника
                    double P = A + B + C;
                    double P2 = P / 2;
                    double S = Math.Sqrt(P2 * (P2 - A) * (P2 - B) * (P2 - C));
                    //определяем размер треугольника
                    if (P >= 100 && S >= 200)
                    {
                        Console.WriteLine("Периметр:" + P);
                        Console.WriteLine("Площадь:" + S);
                        Console.WriteLine("Треугольник большой");
                    }
                    else
                    {
                        if (P <= 3 || S <= 1)
                        {
                            Console.WriteLine("Периметр:" + P);
                            Console.WriteLine("Площадь:" + S);
                            Console.WriteLine("Треугольник маленький");
                        }
                        else
                        {
                            Console.WriteLine("Периметр:" + P);
                            Console.WriteLine("Площадь:" + S);
                            Console.WriteLine("Треугольник средний");
                        }
                    }

                }
                //иначе - треугольник невырожденый
                else
                {
                    Console.WriteLine("Треугольник невырожденный");
                };               
            }
            else
            {
                Console.WriteLine("Неверное значение! Нужно ввести число.");
            };
            //завершение программы
            Console.ReadKey();
        }
    }
}
