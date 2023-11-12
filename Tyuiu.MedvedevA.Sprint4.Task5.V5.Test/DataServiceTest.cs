using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint4.Task5.V5.Lib;

namespace Tyuiu.MedvedevA.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas1 = new int[5, 5] { { -5, 6, -5, 6, -5 }, { 5, -5, -5, 8, -4 }, { -8, 5, 5, 8, -8 }, { 6, -5, -4, 4, 8 }, { -8, -5, -6, 8, 8 } };
            int res = ds.Calculate(mas1);
            int wait = 77;
            Assert.AreEqual(wait, res);
        }
    }
}
