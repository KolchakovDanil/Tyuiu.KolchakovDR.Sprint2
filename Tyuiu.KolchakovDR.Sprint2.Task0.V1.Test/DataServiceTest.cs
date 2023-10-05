using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint2.Task0.V1.Lib;
namespace Tyuiu.KolchakovDR.Sprint2.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        //Hписать программу из операций сравнений (==, !=, <, >, <=, >=,
        //последовательность операций не должна нарушаться) и арифметических выражений,
        //которая вернет логическую последовательность(массив): (True, False, True, False, True, False), 
        //при x = 233, y = 122");
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 233;
            int y = 122;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true, false, true, false, true, false};

            CollectionAssert.AreEqual(wait, res); 
        }
    }
}
