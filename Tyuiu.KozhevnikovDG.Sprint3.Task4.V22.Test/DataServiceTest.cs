using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KozhevnikovDG.Sprint3.Task4.V22.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint3.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = -21.742;
            Assert.AreEqual(wait, res);
        }
    }
}
