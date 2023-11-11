using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.EmelianovaKP.Sprint4.Task7.V21.Lib
{
    public class DataService : ISprint4Task7V21
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;

            int[,] array = new int[n, m];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    array[i, j] = int.Parse(value.Substring(i * m + j, 1));
                    if (array[i, j] % 2 ==0)
                    {
                        count += array[i, j];
                    }
                }
            }

            return count;
        }
    }
}
