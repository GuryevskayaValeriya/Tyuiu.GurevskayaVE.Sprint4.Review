using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint4.TaskReview.V20.Lib;

namespace Tyuiu.GurevskayaVE.Sprint4.TaskReview.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            int n = 5;
            int m = 3;
            int[,] mas = new int[n, m];
            string str = "357951248632587";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 6144;
            Assert.AreEqual(wait, res);
        }
    }
}
