using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MedvedevA.Sprint4.Task2.V7.Lib
{
    public class DataService : ISprint4Task2V7
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    res *= array[i];
                }
            }
            return res;
        }
    }
}
