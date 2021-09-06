using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace OOPLB2
{
    class Book
    {
        private string name;
        private string avtor;
        private int date;

        public Book()
        {
            this.name = Interaction.InputBox("Введіть назву книгі", "Введення");
            this.avtor = Interaction.InputBox("Введіть автора книгі", "Введення");
            this.date = Convert.ToInt32(Interaction.InputBox("Введіть рік книгі", "Введення"));
        }

        public Book(string name, string avtor, int date)
        {
            this.name = name;
            this.avtor = avtor;
            this.date = date;
        }

        private string Year()
        {
            if (date >= 2010) return " Нова книга";
            else return " Стара книга";
        }

        private string Num__year()
        {
            int num = 2021 - date;
            if (num == 0) return " Цього річна книга";
            else return Convert.ToString(num);
        }

        public void Info()
        {
            MessageBox.Show($"Данні книгі:\nНазва: {name} \nАвтор: {avtor} \nРік видання: {date} \nСкільки років книзі: {Num__year()} \nДоп. Інформація: {Year()}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
