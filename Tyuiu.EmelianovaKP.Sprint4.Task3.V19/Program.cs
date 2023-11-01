using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint4.Task3.V19.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Емельянова К. П. | ПКТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Емельянова К. П. | ПКТб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9. Подсчитайте количество   *");
            Console.WriteLine("* четных элементов во всем массиве.                                       *");
            Console.WriteLine("* 6, 5, 6, 3, 8,                                                          *");
            Console.WriteLine("* 9, 4, 4, 3, 4,                                                          *");
            Console.WriteLine("* 3, 3, 6, 8, 6,                                                          *");
            Console.WriteLine("* 6, 5, 3, 4, 3,                                                          *");
            Console.WriteLine("* 9, 3, 5, 3, 7,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int[,] matrix = new int[,] { {6, 5, 6, 3, 8},
                                         {9, 4, 4, 3, 4,}, 
                                         {3, 3, 6, 8, 6,}, 
                                         {6, 5, 3, 4, 3,}, 
                                         {9, 3, 5, 3, 7,} };

            Console.WriteLine("Массив:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество четных элементов = " + ds.Calculate(matrix));

            Console.ReadKey();
        }
    }
}
