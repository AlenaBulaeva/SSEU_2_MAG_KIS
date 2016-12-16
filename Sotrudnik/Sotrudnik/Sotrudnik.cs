using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sotrudnik
{
    class Sotrudnik
    {
        public string FIO = "";                 //ФИО
        public string dr = "";         //
        public string dolgn = "";
        public string oklad = "";                    //
        public double prem = 0.20;
        public double ndfl = 0.18;
        public bool sovm = true;              //Бюджет


        //содержимое полей в виде текста
        public string ToString()
        {
            /*//строка с оценками
            string strOzenki = "";
            //перебор семестров
            for (int i = 0; i < 2 * kurs; i++)
            {
                //выводим номер семестра в начале строки
                strOzenki += (i + 1) + " семестр: ";
                //перебор экзаменов
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] == 1) //неявка
                        strOzenki += "неявка, "; //добавляем оценку к строке
                    else if (ozenki[i, j] > 1) //есть оценка
                        strOzenki += ozenki[i, j] + ", "; //добавляем оценку к строке
                };
                //конец строки
                strOzenki += "Стипендия: " + Stipendia(i) + "руб.\r\n"; ;
            };*/
            return "ФИО: " + FIO + "\r\n" +
                   "№ студбилета: " + dr + "\r\n" +
                   "Курс: " + dolgn + "\r\n" +
                   "Группа: " + oklad + "\r\n" +
                   (sovm ? "По совместительству" : "Не по совместительству") + "\r\n";
        }
    }
}
