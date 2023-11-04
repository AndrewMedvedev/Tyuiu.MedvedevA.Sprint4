using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevA.Sprint4.Task1.V9.Lib;

namespace Tyuiu.MedvedevA.Sprint4.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;


            Console.Write("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numArry = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива:");
                numArry[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numArry[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Произведение всех чётных элеметов массива:" + ds.Calculate(numArry));

            Console.ReadKey();
        }
    }
}
