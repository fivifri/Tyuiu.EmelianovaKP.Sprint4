using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint4.Task6.V7.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            var week = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };

            foreach (var item in week)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Длина > 8: " + ds.Calculate(week));
            Console.ReadKey();
        }
    }
}
