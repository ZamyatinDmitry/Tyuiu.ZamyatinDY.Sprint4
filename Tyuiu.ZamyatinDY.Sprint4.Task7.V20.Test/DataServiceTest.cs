using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using Tyuiu.ZamyatinDY.Sprint4.Task7.V20.Lib;
namespace Tyuiu.ZamyatinDY.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpress()
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "357951248632587";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 6144;
            Assert.AreEqual(wait, res);
        }
    }
}
