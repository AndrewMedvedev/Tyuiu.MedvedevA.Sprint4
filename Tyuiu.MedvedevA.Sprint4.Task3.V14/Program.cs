using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevA.Sprint4.Task3.V14.Lib;

namespace Tyuiu.MedvedevA.Sprint4.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
          
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                *");
            Console.WriteLine("*******************************************************************************************************************");


            Console.WriteLine("Введите количесвто элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2, 8);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }


            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                      *");
            Console.WriteLine("*******************************************************************************************************************");

            int res = ds.Calculate(numsArray[]);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
