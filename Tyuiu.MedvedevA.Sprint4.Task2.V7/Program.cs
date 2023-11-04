using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevA.Sprint4.Task2.V7.Lib;

namespace Tyuiu.MedvedevA.Sprint4.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                array[i] = rnd.Next(4, 9);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }


            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат произведения чётных элементов: " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
