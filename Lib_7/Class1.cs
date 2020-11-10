using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_7
{
  //Класс Triad
   public class Triad
   {
            //Автоматическое свойство value1
            public int value1
            {
                get; set;
            }
            //Автоматическое свойство value2
            public int value2
            {
                get; set;
            }
            //Автоматическое свойство value3
            public int value3
            {
                get; set;
            }
            //Рандомное задание значений
            public void Random()
            {
                Random rnd = new Random();
                value1 = rnd.Next(-100, 100);
                value2 = rnd.Next(-100, 100);
                value3 = rnd.Next(-100, 100);
            }
            //Конструктор со стандартными значениями
            public Triad()
            {
                value1 = 10;
                value2 = 10;
                value3 = 10;
            }
        //Перегруженный оператор для увеличения на 10
        public static Triad operator ++(Triad triad)
        {
            return new Triad { 
                value1 = triad.value1 + 10, 
                value2 = triad.value2 + 10,
                value3 = triad.value3 + 10
            };
        }
        //Перегруженный оператор для увеличения на N
        public static Triad operator +(Triad triad, int N)
        {
            return new Triad {
            value1 = triad.value1 + N,
            value2 = triad.value2 + N,
            value3 = triad.value3 + N,
            };
        }
        //Перегруженный оператор для сравнения
        public static bool operator |(Triad triad1, Triad triad2)
        {
            if ((triad1.value1 > triad2.value1) | ((triad1.value1 == triad2.value1) && (triad1.value2 > triad2.value2) && (triad1.value3 > triad2.value3)))
                return true;
            return false;
        }
        /*
        Увеличение значений на 10
        public void SetParams()
            {
                value1 += 10;
                value2 += 10;
                value3 += 10;
            }

        //Увеличение значений на N
        public void SetParams(int N)
            {
                value1 += N;
                value2 += N;
                value3 += N;
            }

        //Сранение объектов триад
        public bool Compare(Triad triad2)
    {
        if ((value1 > triad2.value1) | ((value1 == triad2.value1) && (value2 > triad2.value2) && (value3 > triad2.value3)))
        {
            return true;//triad1 > triad2
        }
        else
        {
            return false;//triad1 < triad2
        }
        */
    }
}

