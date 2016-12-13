using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    class Student
    {
        public string FIO = "";                 //ФИО
        public string Nstud = "000000";         //№ студБилета
        public int kurs = 1;                    //Курс
        public string gruppa = "";              //Группа
        public bool budget = true;              //Бюджет
        public byte[,] ozenki = new byte[8, 5]; //Оценки
        
        //содержимое полей в виде текста
        public string ToString()
        {
            return "ФИО: " + FIO + "\r\n" +
                "№ студбилета: " + Nstud + "\r\n" +
                "Курс: " + kurs + "\r\n" +
                "Группа: " + gruppa + "\r\n" +
                (budget ? "На бюджетной основе" : "На коммерческой основе");
        }
    }
}
