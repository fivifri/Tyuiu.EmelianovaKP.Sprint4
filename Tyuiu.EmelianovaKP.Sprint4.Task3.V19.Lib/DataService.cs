using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.EmelianovaKP.Sprint4.Task3.V19.Lib
{
    public class DataService : ISprint4Task3V19
    {
        public int Calculate(int[,] array)
        {
            int count = 0;

            foreach(var item in array)
            {
                if (item % 2 == 0)
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
