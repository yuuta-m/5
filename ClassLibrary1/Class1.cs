using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_7
{
    public class Triad
    {
        public int value1
        {
           get; set;
        }
        public int value2
        {
            get; set;
        }
        public int value3
        {
            get; set;
        }

        public void Random()
        {
            Random rnd = new Random();
            value1 = rnd.Next(-100, 100);
            value2 = rnd.Next(-100, 100);
            value3 = rnd.Next(-100, 100);
        }

        public void SetParams(int initValue1, int initValue2, int initValue3)
        {
            value1 = initValue1;
            value2 = initValue2;
            value3 = initValue3;
        }

        public void SetParams()
        {
            value1 = value1 + 10;
            value2 = value2 + 10;
            value3 = value3 + 10;
        }

        public void SetParams(int initValue)
        {
            value1 = value1 + initValue;
            value2 = value2 + initValue;
            value3 = value3 + initValue;
        }

        public bool Compare(Triad triad2)
        {
            if((value1 > triad2.value1) | ((value1 == triad2.value1) && (value2 > triad2.value2) && (value3 > triad2.value3)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
