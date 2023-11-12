using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevA.Sprint4.Task7.V7.Lib;

namespace Tyuiu.MedvedevA.Sprint4.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string value = "31415926";
            DataService ds = new DataService();

            Assert.AreEqual(5, ds.Calculate(n, m, value));
        }
    }
}
