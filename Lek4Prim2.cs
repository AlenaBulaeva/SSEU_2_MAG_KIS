using System;
using System.Collections.Generic;
using System.Text;

namespace Identificator
{
    class Lek4Prim2
    {
        static void Main(string[] args)
        {
            bool noErrors = true; //íåò îøèáîê, ïî óìîë÷àíèş
            Console.WriteLine("Ââåäèòå èäåíòèôèêàòîğ: ");
            string id = Console.ReadLine(); //èäåíòèôèêàòîğ
            //ïğîâåğêà ïåğâîãî ñèìâîëà
            if (!((id[0] >= 'a') && (id[0] <= 'z') // íå ñòğî÷íàÿ áóêâà
                || (id[0] >= 'A') && (id[0] <= 'Z') // èëè çàãëàâíàÿ áóêâà
                || (id[0] == '_'))) //èëè ïîä÷åğêèâàíèå
            {
                noErrors = false;
                Console.WriteLine("Ïåğâûé ñèìâîë äîëæåí áûòü ëàòèíñêîé áóêâîé èëè çíàêîì ïîä÷åğêèâàíèÿ!");
                // ïğîâåğêà îñòàëüíûõ ñèìâîëîâ
                for (int i = 1; i < id.Length; i++)
                {
                    //ïğîâåğêà i-òîãî ñèìâîëà
                    if (!((id[i] >= 'a') && (id[i] <= 'z') // íå ñòğî÷íàÿ áóêâà
                    || (id[i] >= 'A') && (id[i] <= 'Z') // èëè çàãëàâíàÿ áóêâà
                    || (id[i] >= '0') && (id[i] <= '9') // èëè öèôğà
                    || (id[0] == '_'))) //èëè ïîä÷åğêèâàíèå
                    {
                        noErrors = false;
                        Console.WriteLine("Ñèìâîë " + i + "(" + id[i] + ")" + " äîëæåí áûòü ëàòèíñêîé áóêâîé, öèôğîé èëè çíàêîì ïîä÷åğêèâàíèÿ!");
                    };
                };
            };
            if (noErrors)
            {
                Console.WriteLine("Èäåíòèôèêàòîğ âåğíûé.");
            };
            Console.ReadKey();
        }
    }
}
