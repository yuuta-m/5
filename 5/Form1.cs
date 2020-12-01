using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_7;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Создание объектов дат
        Date date1 = new Date();
        Date date2 = new Date();

        //Кнопка "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Кнопка "Справка"
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №7. Бороненкова Дария, гр.ИСП - 31.\n" +
                "Задание: Использовать класс Triad (тройка чисел).\n" +
                "Определить производный класс Date с полями: год, месяц и день.\n" +
                "Определить полный набор методов сравнения дат. ",
                "О программе");
        }
        //Кнопка "Очистить дату 1"
        private void очиститьТриаду1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triad1value1.Clear();
            triad1value2.Clear();
            triad1value3.Clear();
        }
        //Кнопка "Очистить дату 2"
        private void очиститьТриаду2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triad2value1.Clear();
            triad2value2.Clear();
            triad2value3.Clear();
        }
        //Задание даты №1
        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(triad1value1.Text, out int d1) && Int32.TryParse(triad1value2.Text, out int m1) && Int32.TryParse(triad1value3.Text, out int y1))
            {
                date1.Value1 = d1;
                date1.Value2 = m1;
                date1.Value3 = y1;
            }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }
        //Задание даты №2
        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(triad2value1.Text, out int d2) && Int32.TryParse(triad2value2.Text, out int m2) && Int32.TryParse(triad2value3.Text, out int y2))
            {
                date2.Value1 = d2;
                date2.Value2 = m2;
                date2.Value3 = y2;
            }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }
        //Присваивание значений по умолчанию при первой загрузке программы
        private void Form1_Load(object sender, EventArgs e)
        {
            triad1value1.Text = date1.Value1.ToString();
            triad1value2.Text = date1.Value2.ToString();
            triad1value3.Text = date1.Value3.ToString();
        }
        //Кнопка "Сравнить"
        private void сравнитьТриадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (date1.Compare(date2) == 1)
            {
                MessageBox.Show("Дата №1 больше даты №2", "Результат сравнения");
            }
            else if (date1.Compare(date2) == -1)
            {
                MessageBox.Show("Дата №1 меньше даты №2", "Результат сравнения");
            }
            else
            {
                MessageBox.Show("Даты равны", "Результат сравнения");
            }
        }
        //Кнопка "Очистить всё"
        private void button14_Click(object sender, EventArgs e)
        {
            triad1value1.Clear();
            triad1value2.Clear();
            triad1value3.Clear();
            triad2value1.Clear();
            triad2value2.Clear();
            triad2value3.Clear();
        }
    }
}

