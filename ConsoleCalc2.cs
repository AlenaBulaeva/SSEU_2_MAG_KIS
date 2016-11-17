using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc2
{
    class ConsoleCalc2
    {//ввод операнда с консоли с проверкой значени€
        static double ReadOperand()
        {
            double operand = 0;   //значение операнда
            Console.Write("¬ведите число: ");
            //повтор€ть ввод, пока не будет введено корректное значение
            while (!double.TryParse(Console.ReadLine(), out operand))
            {
                Console.Write("Ќеверное значение! ¬ведите число: ");
            };
            //вернуть значение
            return operand;
        }
        static void Main(string[] args)
        {
            //первый операнд
            double operand1 = ReadOperand();
            //второй операнд
            double operand2;
            //действие
            string operation;
            do
            {
                //выбираем операцию
                Console.WriteLine("+ - сложение");
                Console.WriteLine("- - вычитание");
                Console.WriteLine("* - умножение");
                Console.WriteLine("/ - деление");
                Console.WriteLine("sqrt - корень из числа");
                Console.Write("¬ыберите действие: ");
                operation = Console.ReadLine();
                operation = operation.ToLower();
                switch (operation)
                {
                    //операции с двум€ операндами
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        //считываем второй операнд
                       operand2 = ReadOperand();
                            //кака€ именно операци€?
                            switch (operation)
                            {
                                case "+": operand1 = operand1 + operand2; break;
                                case "-": operand1 = operand1 - operand2; break;
                                case "*": operand1 = operand1 * operand2; break;
                                case "/": operand1 = operand1 / operand2; break;
                            };
                        break;
                    //операци€ с одним операндом
                    case "sqrt": operand1 = Math.Sqrt(operand1); break;
                    //выход из программы
                    case "quit": case "exit": return;
                    //недопустимые операции
                    default: Console.WriteLine("Ќеверна€ операци€!"); break;
                };
                //выводим результат
                Console.WriteLine("–езультат: " + operand1);
                Console.WriteLine("ƒл€ выхода набирите quit или exit");
            }
            //пока не будет введена команда выхода
            while (!((operation == "quit") || (operation == "exit")));
        }
    }
}
