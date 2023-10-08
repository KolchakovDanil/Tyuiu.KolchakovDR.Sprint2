using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint2.Task1.V17.Lib;

namespace Tyuiu.KolchakovDR.Sprint2.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        //Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность 
        //можно чередовать, но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, 
        //последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет 
        //логическую последовательность(массив): (True, False, True, True, True, False), при a = 135, b = 123, c = 455, d = 321

        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
