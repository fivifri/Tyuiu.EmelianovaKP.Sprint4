using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint4.Task5.V7.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Write("Введите кол-во строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите кол-во столбцов в массиве: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rnd.Next(-7, 7);
                    Console.Write($"{array[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Количество отрицательных элементов = " + ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
