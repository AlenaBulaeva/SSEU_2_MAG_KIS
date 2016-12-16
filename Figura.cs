using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek6Zad1
{
    class Figura
    {
        public double x1, y1; //верхний левый угол или центр окружности
        public double x2, y2; //правый нижний угол
        public double r; //радиус

        //конструктор по умолчанию
        public Figura() { }

        //создание новой фигуры путем копирования полей из другого
        public Figura(Figura copyFrom)
        {
            //копируем значения всех полей
            x1 = copyFrom.x1;
            y1 = copyFrom.y1;
            x2 = copyFrom.x2;
            y2 = copyFrom.y2;
            r = copyFrom.r;
        }

        class Figura2
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
                Rectangle pryam; //один прямоугольник
                Krug K; //один круг
                Console.WriteLine("\t\t\t╔══════════════════════════════╗");
                Console.WriteLine("\t\t\t║        Создание фигуры       ║");
                Console.WriteLine("\t\t\t╚══════════════════════════════╝");

                //создаем новый прямоугольник с введенными координатами
                pryam = new Rectangle(ReadCoord("х верхнего левого угла: "),
                    ReadCoord("y верхнего левого угла: "),
                    ReadCoord("х нижнего правого угла: "),
                    ReadCoord("y нижнего правого угла: "));
                //создаем новый круг с введенными координатами
                K = new Krug(ReadCoord("х центра окружности: "),
                    ReadCoord("y центра окружности: "),
                    ReadCoord("r радиус окружности: "));
                char key; //нажатая клавиша
                do
                {
                    Console.Clear(); //очистка окна
                    //вывод координат
                    Console.WriteLine("\n<<Прямоугольник>>");
                    Console.WriteLine("\nВерхний левый угол имеет координаты: х = " + pryam.x1 + ", y = " + pryam.y1);
                    Console.WriteLine("Нижний правый угол имеет координаты: х = " + pryam.x2 + ", y = " + pryam.y2);
                    Console.WriteLine("Ширина прямоугольника = " + pryam.Width());
                    Console.WriteLine("Высота прямоугольника = " + pryam.Height());
                    Console.WriteLine("Периметр прямоугольника = " + pryam.P());
                    Console.WriteLine("Площадь прямоугольника = " + pryam.S());
                    Console.WriteLine("\n<<Окружность>>");
                    Console.WriteLine("\nЦентр окружности имеет координаты: х = " + K.x1 + ", y = " + K.y1);
                    Console.WriteLine("Радиус окружности = " + K.r);
                    Console.WriteLine("Периметр окружности = " + K.P());
                    Console.WriteLine("Площадь окружности = " + K.S());
                    //меню
                    Console.WriteLine("\n\t\t\t╔══════════════════════════════╗");
                    Console.WriteLine("\t\t\t║             МЕНЮ             ║");
                    Console.WriteLine("\t\t\t║ a - является ли квадратом?   ║");
                    Console.WriteLine("\t\t\t║ b - переместить              ║");
                    Console.WriteLine("\t\t\t║ c - изменить ширину          ║");
                    Console.WriteLine("\t\t\t║ d - изменить высоту          ║");
                    Console.WriteLine("\t\t\t║ e - переместить окружность   ║");
                    Console.WriteLine("\t\t\t║ m - уменьшить окружность     ║");
                    Console.WriteLine("\t\t\t║ p - проверить принадлежность ║");
                    Console.WriteLine("\t\t\t║ ESC - выход                  ║");
                    Console.WriteLine("\t\t\t╚══════════════════════════════╝");

                    //нажатие клавиш
                    key = Console.ReadKey().KeyChar;
                    //проверка нажатой клавиши
                    switch (key)
                    {
                        case 'a':
                            Console.Clear();
                            if (pryam.IsSquare())
                                Console.WriteLine("Квадрат (" + pryam.Width() + " = " + pryam.Height() + ")");
                            else
                                Console.WriteLine("Не квадрат (" + pryam.Width() + " != " + pryam.Height() + ")");
                            Console.WriteLine("Нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                        case 'b': //перемещение
                            Console.Clear();
                            pryam.Move(ReadCoord(" по х: "), ReadCoord(" по y: "));
                            Console.ReadKey();
                            break;
                        case 'c': //измерить ширину
                            Console.Clear();
                            Console.WriteLine("Какую установить ширину?");
                            pryam.SetWidth(ReadCoord(""));
                            Console.WriteLine("Нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                        case 'd': //изменить высоту
                            Console.Clear();
                            Console.WriteLine("Какую установить высоту?");
                            pryam.SetHeight(ReadCoord(""));
                            Console.WriteLine("Нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                        case 'e': //переместить
                            Console.Clear();
                            K.move(ReadCoord(" по х: "), ReadCoord(" по y: "));
                            Console.ReadKey();
                            break;
                        case 'm': //уменьшить площадь
                            Console.Clear();
                            Console.WriteLine("Во сколько раз уменьшить прощадь окружности?");
                            K.umenish(ReadCoord(""));
                            Console.WriteLine("Нажмите любую клавишу");
                            Console.ReadKey();
                            break;
                        case 'p': //принадлежность 
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

        //прямоугольник
        class Rectangle : Figura
        {
            //скопировать
            public Rectangle(Figura copyFrom) : base(copyFrom) { }

            public Rectangle(double x1, double y1, double x2, double y2)
            {
                //начальные координаты
                this.x1 = x1; this.y1 = y1;
                this.x2 = x2; this.y2 = y2;
            }
            //ширина
            public double Width()
            {
                return Math.Abs(x2 - x1);
            }
            //высота
            public double Height()
            {
                return Math.Abs(y2 - y1);
            }
            //периметр
            public double P()
            {
                // 2* (ширина + высота)
                return 2 * (Width() + Height());
            }
            //площадь
            public double S()
            {
                //ширина * высота
                return Width() * Height();
            }
            //квадрат?
            public bool IsSquare()
            {
                //ширина = высота?
                return Width() == Height();
            }
            //перемещение
            public void Move(double x, double y)
            {
                x1 += x; x2 += x;
                y1 += y; y2 += y;
            }
            //изменить ширину
            public void SetWidth(double newWidth)
            {
                x2 = x1 + newWidth;
            }
            //изменить высоту
            public void SetHeight(double newHeight)
            {
                y2 = y1 + newHeight;
            }
        }

        //круг
        class Krug : Figura
        {
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
                double S2 = S() / n;
                r = Math.Sqrt(S2 / Math.PI);
            }

            // принадлежность окружности
            public bool inKrug(double X2, double Y2)
            {
                v = (((Math.Pow((X2 - x1), 2)) + (Math.Pow((Y2 - y1), 2))) <= Math.Pow(r, 2));
                return v;
            }
        }
    }
}
