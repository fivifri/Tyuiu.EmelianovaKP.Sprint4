using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint4.Task4.V29.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("Введите кол-во строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите кол-во столбцов в массиве: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Введите {i}, {j} элемент: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();
            }

            Console.WriteLine("Сумма четных элементов = " + ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
