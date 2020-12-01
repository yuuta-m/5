using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_7
{

    //Класс Triad
    public class Triad
    {
        //Автоматическое свойство value1
        public int Value1
        {
            get; set;
        }
        //Автоматическое свойство value2
        public int Value2
        {
            get; set;
        }
        //Автоматическое свойство value3
        public int Value3
        {
            get; set;
        }
        public Triad(int value1, int value2, int value3)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }
        //Рандомное задание значений
        public void Random()
        {
            Random rnd = new Random();
            Value1 = rnd.Next(-100, 100);
            Value2 = rnd.Next(-100, 100);
            Value3 = rnd.Next(-100, 100);
        }
        //Конструктор со стандартными значениями
        public Triad()
        {
            Value1 = 10;
            Value2 = 10;
            Value3 = 10;
        }
    }
    public class Date : Triad
    {
        int value1, value2, value3;

        public Date(int Value1, int Value2, int Value3) : base(Value1, Value2, Value3) 
        {
            // вспомогательные булевые переменные
            bool y = false,
                 m = false,
                 d = false;
            //Проверка коррректности ввода для года
            if (Value3 < 9999 && Value3 > 1753)
            {
                y = true;
            }
            else
            {
                MessageBox.Show("Некорректное значение года");
            }
            //Проверка коррректности ввода для месяца
            if (Value2 <= 12 && Value2 >= 1)
            {
                m = true;
            }
            else
            {
                MessageBox.Show("Некорректное значение месяца");
            }
            //Проверка коррректности ввода для дня
            if (Value2 == 1 && Value2 == 3 && Value2 == 5 && Value2 == 7 && Value2 == 8 && Value2 == 10 && Value2 == 12)
            {
                if (Value1 > 0 && Value1 <= 31)
                {
                    d = true;
                }
                else
                {
                    MessageBox.Show("Некорректное значение дня");
                }
            }
            if (Value2 == 4 && Value2 == 6 && Value2 == 9 && Value2 == 11)
            {
                if (Value1 > 0 && Value1 <= 31)
                {
                    d = true;
                }
                else
                {
                    MessageBox.Show("Некорректное значение дня");
                }
            }
            if (Value3 % 4 == 0)
            {
                if (Value1 > 0 && Value1 <= 29)
                {
                    d = true;
                }
            }
            else if (Value1 > 0 && Value1 <= 29)
            {
                d = true;
            }
            else
            {
                MessageBox.Show("Некорректное значение дня");
            }
            // если дата правильная, задаем значения
            if (y && m && d)
            {
                this.Value3 = Value3;
                this.Value2 = Value2;
                this.Value1 = Value1;
            }
            else
            {
                MessageBox.Show("Некорректная дата!");
            }
        }
        //Конструктор со значениями по умолчанию
        public Date()
        {
            value1 = 1;
            value2 = 12;
            value3 = 2020;
        }
        //Проверка коррректности ввода для года
        public new int Value3
        {
            get { return value3; }
            set
            {
                if (value < 9999 && value > 0)
                {
                    value3 = value;
                }
                else
                {
                    MessageBox.Show("Некорректное значение года");
                }
            }
        }
        //Проверка коррректности ввода для месяца
        public new int Value2
        {
            get { return value2; }
            set
            {
                if (value <= 12 && value >= 1)
                {
                    value2 = value;
                }
                else
                {
                    MessageBox.Show("Некорректное значение месяца");
                }
            }
        }
        //Проверка коррректности ввода для дня
        public new int Value1
        {
            get { return value1; }
            set
            {
                if (Value2 == 1 && Value2 == 3 && Value2 == 5 && Value2 == 7 && Value2 == 8 && Value2 == 10 && Value2 == 12)
                {
                    if (value > 0 && value <= 31)
                    {
                        value1 = value;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение дня");
                    }
                }
                if (Value2 == 4 && Value2 == 6 && Value2 == 9 && Value2 == 11)
                {
                    if (value > 0 && value <= 31)
                    {
                        value1 = value;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение дня");
                    }
                }
                if (Value3 % 4 == 0)
                {
                    if (value > 0 && value <= 29)
                    {
                        value1 = value;
                    }
                }
                else if (value > 0 && value <= 29)
                {
                    value1 = value;
                }
                else
                {
                    MessageBox.Show("Некорректное значение дня");
                }
            }
        }
         //Сравнение
        public int Compare (Date date2)
        {
            if ((Value3 > date2.Value3) | ((Value3 == date2.Value3) && (Value1 > date2.Value1) && (Value2 > date2.Value2)))
            {
                return 1;//Дата 1 больше даты 2
            }
            else if ((Value1 == date2.Value1) && (Value2 == date2.Value2) && (Value3 == date2.Value3))
            {
                return 0;//Даты равны
            }
            else
            {
                return -1;//Дата 1 меньше даты 2
            }
        }
    }
}

