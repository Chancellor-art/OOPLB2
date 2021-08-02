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

        public void Info()
        {
            MessageBox.Show($"Данні книгі:\nНазва:{name} \nАвтор:{avtor} \nРік видання:{date}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
