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

        //Создание объектов триад
        private Triad triad1 = new Triad();
        private Triad triad2 = new Triad();

        //Кнопка "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Кнопка "Справка"
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №5. Бороненкова Дария, гр.ИСП - 31.\n" +
                "Задание: Создать класс Triad (тройка чисел). Создать необходимые методы и свойства. Определить метод сравнения триад.\n" +
                "Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения всех чисел на 10",
                "О программе");
        }
        //Кнопка "Очистить триаду 1"
        private void очиститьТриаду1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triad1value1.Clear();
            triad1value2.Clear();
            triad1value3.Clear();
        }
        //Кнопка "Очистить триаду 2"
        private void очиститьТриаду2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triad2value1.Clear();
            triad2value2.Clear();
            triad2value3.Clear();
        }
        //Задание числа 1 триады 1 пользователем вручную
        private void задатьЧисло1Триады1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(triad1value1.Text, out int tr1val1))
            {
                triad1.value1 = tr1val1;
                rezTriad1Value1.Text = triad1.value1.ToString();
            }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }
        //Задание числа 2 триады 1 пользователем вручную
        private void задатьЧисло2Триады1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(triad1value2.Text, out int tr1val2))
            {
                triad1.value2 = tr1val2;
                rezTriad1Value2.Text = triad1.value2.ToString();
            }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }
        //Задание числа 3 триады 1 пользователем вручную
        private void задатьЧисло3Триады1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(triad1value3.Text, out int tr1val3))
            {
                triad1.value3 = tr1val3;
                rezTriad1Value3.Text = triad1.value3.ToString();
            }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }
        //Задание числа 1 триады 2 пользователем вручную
        private void задатьЧисло1Триады2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(triad2value1.Text, out int tr2val1))
            {
                triad2.value1 = tr2val1;
                rezTriad2Value1.Text = triad2.value1.ToString();
            }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }
        //Задание числа 2 триады 2 пользователем вручную
        private void задатьЧисло2Триады2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(triad2value2.Text, out int tr2val2))
            {
                triad2.value2 = tr2val2;
                rezTriad2Value2.Text = triad2.value2.ToString();
            }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }
        //Задание числа 3 триады 2 пользователем вручную
        private void задатьЧисло3Триады2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(triad2value3.Text, out int tr2val3))
            {
                triad2.value3 = tr2val3;
                rezTriad2Value3.Text = triad2.value3.ToString();
            }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }
        //Задание чисел триады 1 автоматически рандомно
        private void задатьЧислаТриады1АвтоматическиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triad1.Random();
            rezTriad1Value1.Text = triad1.value1.ToString();
            rezTriad1Value2.Text = triad1.value2.ToString();
            rezTriad1Value3.Text = triad1.value3.ToString();
        }
        //Задание чисел триады 2 автоматически рандомно
        private void задатьЧислаТриады2АвтоматическиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triad2.Random();
            rezTriad2Value1.Text = triad2.value1.ToString();
            rezTriad2Value2.Text = triad2.value2.ToString();
            rezTriad2Value3.Text = triad2.value3.ToString();
        }
        //Кнопка "Сравнить"
        private void сравнитьТриадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (triad1.Compare(triad2))
            {
                MessageBox.Show("Триада №1 больше триады №2", "Результат сравнения");
            }
            else
            {
                MessageBox.Show("Триада №2 больше триады №1", "Результат сравнения");
            }

        }
        //Кнопка "Увеличить на 10"
        private void увеличитьЧислаНа10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triad1.SetParams();
            rezTriad1Value1.Text = triad1.value1.ToString();
            rezTriad1Value2.Text = triad1.value2.ToString();
            rezTriad1Value3.Text = triad1.value3.ToString();
            triad2.SetParams();
            rezTriad2Value1.Text = triad2.value1.ToString();
            rezTriad2Value2.Text = triad2.value2.ToString();
            rezTriad2Value3.Text = triad2.value3.ToString();

        }
        //Кнопка "Увеличить на N"
        private void увеличитьЧислаНаNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(n.Text, out int N))
            {
                triad1.SetParams(N);
                rezTriad1Value1.Text = triad1.value1.ToString();
                rezTriad1Value2.Text = triad1.value2.ToString();
                rezTriad1Value3.Text = triad1.value3.ToString();
                triad2.SetParams(N);
                rezTriad2Value1.Text = triad2.value1.ToString();
                rezTriad2Value2.Text = triad2.value2.ToString();
                rezTriad2Value3.Text = triad2.value3.ToString();
            }
            else
            {
                MessageBox.Show("Введите число", "Ошибка");
            }
        }
        //Очищение всех форм
        private void очиститьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triad1value1.Clear();
            triad1value2.Clear();
            triad1value3.Clear();
            triad2value1.Clear();
            triad2value2.Clear();
            triad2value3.Clear();
            rezTriad1Value1.Clear();
            rezTriad1Value2.Clear();
            rezTriad1Value3.Clear();
            rezTriad2Value1.Clear();
            rezTriad2Value2.Clear();
            rezTriad2Value3.Clear();
            n.Clear();
        }
        //Вывод при загрузке значений по умолчанию
        private void Form1_Load_1(object sender, EventArgs e)
        {
            rezTriad1Value1.Text = triad1.value1.ToString();
            rezTriad1Value2.Text = triad1.value2.ToString();
            rezTriad1Value3.Text = triad1.value3.ToString();
            rezTriad2Value1.Text = triad2.value1.ToString();
            rezTriad2Value2.Text = triad2.value2.ToString();
            rezTriad2Value3.Text = triad2.value3.ToString();
        }
    }
}

