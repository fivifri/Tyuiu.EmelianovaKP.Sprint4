using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint4.Task0.V23.Lib;

namespace Tyuiu.EmelianovaKP.Sprint4.Task0.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Емельянова К. П. | ПКТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Емельянова К. П. | ПКТб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива. {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            Console.WriteLine("Исходный массив:");
            
            foreach (int x in array)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение нечетных элементов массива:");

            Console.WriteLine(ds.GetMultOddArrEl(array));
            
            Console.ReadKey();
        }
    }
}
