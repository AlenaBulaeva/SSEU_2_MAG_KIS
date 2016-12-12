using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4Zad1
{
    class Lek4Zad1
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Нажмите любую клавишу");
            char.TryParse(Console.ReadLine(), out a);
            int b;
            b = Convert.ToInt32(a);
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
