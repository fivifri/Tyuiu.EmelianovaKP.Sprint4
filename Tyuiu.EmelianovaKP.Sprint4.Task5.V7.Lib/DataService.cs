using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.EmelianovaKP.Sprint4.Task5.V7.Lib
{
    public class DataService : ISprint4Task5V7
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;

            foreach (var item in matrix)
            {
                if (item < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
