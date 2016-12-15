using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek5Zad2
{
    class Krug
    {
        //круг
        class Krug
        {
            public double x1, y1; //центр окружности
            public double r; //радиус
            public bool v = false;
            
            public Krug(double x1, double y1, double r)
            {
                //начальные координаты
                this.x1 = x1; this.y1 = y1;
                this.r = r; 
            }
            
            // периметр
            public double P()
            { 
                return 2 * Math.PI * r; 
            }
            
            // площадь 
            public double S() 
            { 
                return Math.PI * r * r; 
            }
                
            //перемещение
            public void move(double x, double y)
            {
                x1 += x; y1 += y; 
                
            }
            
            //уменьшить площать в n раз
            public void umenish(double n)
            {
                double S2 =  S() / n;
                r = Math.Sqrt(S2 / Math.PI);
            }
   
            // принадлежность окружности
            public bool inKrug(double X2, double Y2)
            {
                v = (((Math.Pow((X2 - x1), 2)) + (Math.Pow((Y2 - y1), 2))) <= Math.Pow(r, 2));
                return v;
            }
        }
        
        class Krug2
        {
            //ввод одной координаты, сообщение message выводится пользователю
            static double ReadCoord(string message)
            {
                double coord;
                Console.Write("Введите координату " + message);
                while (!double.TryParse(Console.ReadLine(), out coord))
                {
                    Console.Write("Ошибка! Введите число: ");
                };
                return coord;                 
            }
               
            static void Main(string[] args)
            {
                Krug K; //один круг    
                Console.WriteLine("Создание окружности.");
                //создаем новый круг с введенными координатами
                K = new Krug(ReadCoord("х центра окружности: "),
                    ReadCoord("y центра окружности: "),
                    ReadCoord("r радиус окружности: "));
                char key; //нажатая клавиша
                do
                {
                    Console.Clear(); //очистка окна
                    //вывод координат
                    Console.WriteLine("Центр окружности имеет координаты: х = " + K.x1 + ", y = " + K.y1);
                    Console.WriteLine("Радиус окружности: r = " + K.r);
                    Console.WriteLine("Периметр окружности = " + K.P());
                    Console.WriteLine("Площадь окружности = " + K.S());
                    //меню
                    Console.WriteLine("\t\t\t╔═════════════════════════════╗");
                    Console.WriteLine("\t\t\t║             МЕНЮ            ║");
                    Console.WriteLine("\t\t\t║ a - переместить             ║");
                    Console.WriteLine("\t\t\t║ b - уменьшить площадь       ║");
                    Console.WriteLine("\t\t\t║ c - принадлежность          ║");
                    Console.WriteLine("\t\t\t║ ESC - выход                 ║");
                    Console.WriteLine("\t\t\t╚═════════════════════════════╝");

                    //нажатие клавиш
                    key = Console.ReadKey().KeyChar;
                    //проверка нажатой клавиши
                    switch (key)
                    {
                        case 'a': //переместить
                            Console.Clear();
                            K.move(ReadCoord(" по х: "), ReadCoord(" по y: "));
                            Console.ReadKey();
                            break;
                        case 'b': //уменьшить площадь
                            Console.Clear();
                            Console.WriteLine("Во сколько раз уменьшить прощадь окружности?");
                            K.umenish(ReadCoord(""));
                            Console.WriteLine("Нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                        case 'c': //принадлежность 
                            Console.Clear();
                            Console.WriteLine("Принадлежит ли точка окружности?");
                            K.inKrug(ReadCoord(" по х: "), ReadCoord(" по y: "));
                            if (K.v)
                            {
                                Console.WriteLine("Точка принадлежит окружности");
                            }
                            else
                            {
                                Console.WriteLine("Точка не принадлежит окружности");
                            }
                            Console.WriteLine("Нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                    };
                }
                while (key != (char)27); //пока не нажат Esc
            }
        }
    }
}