using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.EmelianovaKP.Sprint4.Task2.V18.Lib
{
    public class DataService : ISprint4Task2V18
    {
        public int Calculate(int[] array)
        {
            int product = 1;

            foreach ( int x in array )
            {
                if ( x >= 2 && x <= 8 && x % 2 == 0)
                {
                    product *= x;
                }
            }

            return product;
        }
    }
}
