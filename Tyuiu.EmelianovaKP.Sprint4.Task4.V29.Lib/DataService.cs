using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.EmelianovaKP.Sprint4.Task4.V29.Lib
{
    public class DataService : ISprint4Task4V29
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;

            foreach (var item in matrix)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }

            return sum;
        }
    }
}
