using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint4.Task6.V30.Lib;
namespace Tyuiu.ZamyatinDY.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            var three = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            string[] res = ds.Calculate(three);
            string[] wait = { "Береза" };
            CollectionAssert.AreEqual(wait,res);
        }
    }
}
