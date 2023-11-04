using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint4.Task2.V7.Lib;

namespace Tyuiu.MedvedevA.Sprint4.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] lol = { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9 };

            int res = ds.Calculate(lol);
            int wait = 36864;

            Assert.AreEqual(wait, res);
        }
    }
}
