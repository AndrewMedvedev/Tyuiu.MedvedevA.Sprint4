using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevA.Sprint4.Task0.V27.Lib;

namespace Tyuiu.MedvedevA.Sprint4.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");

            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                              -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Произведение нечетных элементов массива = " + ds.GetMultOddArrEl(numsArray));
            Console.ReadKey();
        }
    }
}
