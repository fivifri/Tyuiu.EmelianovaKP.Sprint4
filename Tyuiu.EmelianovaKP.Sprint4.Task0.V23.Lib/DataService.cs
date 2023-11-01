using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.EmelianovaKP.Sprint4.Task0.V23.Lib
{
    public class DataService : ISprint4Task0V23
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;

            foreach(int x in array)
            {
                if (x % 2 != 0)
                {
                    product *= x;
                }
            }

            return product;
        }
    }
}
