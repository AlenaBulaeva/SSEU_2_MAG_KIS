using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sotrudnik
{
    public partial class FormSotrudnik : Form
    {
        Sotrudnik sotrudnik1 = new Sotrudnik();
        
        public FormSotrudnik()
        {
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            sotrudnik1.FIO = textBoxFIO.Text; //сохранить ФИО
            textBoxSotrudnikInfo.Text = sotrudnik1.ToString(); //вывести на экран
        }

        private void textBoxDR_TextChanged(object sender, EventArgs e)
        {
            sotrudnik1.dr = textBoxDR.Text;
            textBoxSotrudnikInfo.Text = sotrudnik1.ToString(); //вывести на экран
        }

        private void textBoxDolgn_TextChanged(object sender, EventArgs e)
        {
            sotrudnik1.dolgn = textBoxDolgn.Text;
            textBoxSotrudnikInfo.Text = sotrudnik1.ToString(); //вывести на экран
        }

        private void textBoxOklad_TextChanged(object sender, EventArgs e)
        {
            sotrudnik1.oklad = textBoxOklad.Text;
            textBoxSotrudnikInfo.Text = sotrudnik1.ToString(); //вывести на экран
        }

        private void radioButtonSovm_CheckedChanged(object sender, EventArgs e)
        {
            //если выбрано обучение на бюджете
            if (radioButtonSovm.Checked)
            {
                //то создать бюджетника
               // sotrudnik1 = new SotrudnikSovm(sotrudnik1);

            }
            //иначе - обучение на коммерческой основе
            else
            {
                //создать платника
               // sotrudnik1 = new SotrudnikNeSovm(sotrudnik1);
            }
            textBoxSotrudnikInfo.Text = sotrudnik1.ToString(); //вывести на экран
        }
    }
}
