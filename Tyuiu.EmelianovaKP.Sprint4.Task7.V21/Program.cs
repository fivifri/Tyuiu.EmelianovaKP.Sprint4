using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint4.Task7.V21.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ds = new DataService();

            string str = "425963128528";

            Console.WriteLine("строка: " + str);

            Console.WriteLine("сумма четных цифр: " + ds.Calculate(4, 3, "425963128528"));
            Console.ReadKey();
        }
    }
}
