using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint4.Task5.V25.Lib;
namespace Tyuiu.ZamyatinDY.Sprint4.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas1 = new int[5, 5] { {2, -3, 2, 3, 3},
                                          {3, -4, 3, 2, 2},
                                          {3, 2, 3, -3, -4},
                                          {-1, 2, 0, -3, -1},
                                          {2, 3, -2, -4, -4} };
            int res = ds.Calculate(mas1);
            int wait = 35;
            Assert.AreEqual(wait, res);
        }
    }
}
