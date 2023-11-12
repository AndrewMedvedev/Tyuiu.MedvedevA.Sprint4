using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevA.Sprint4.Task6.V28.Lib;

namespace Tyuiu.MedvedevA.Sprint4.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] data = { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            DataService ds = new DataService();

           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= data.Length - 1; i++)
            {
                Console.WriteLine(data[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(data);

            Console.WriteLine("Элементы массива, длина которых равна 4 символам: ");
            for (int i = 0; i <= res.Length - 1; i++)
            {
                Console.Write($"{res[i]}\n");
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
