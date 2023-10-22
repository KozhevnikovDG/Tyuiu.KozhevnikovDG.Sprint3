using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.Sprint3.Task3.V22.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "tbtbbb dsfbg bbg";

            char chr = 'b';

            double res = ds.GetMaxCharCount(str, chr);
            int wait = 7;

            Assert.AreEqual(wait, res);
        }
    }
}
