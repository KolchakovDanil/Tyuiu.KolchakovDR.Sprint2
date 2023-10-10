using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint2.Task3.V24.Lib;

namespace Tyuiu.KolchakovDR.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            Assert.AreEqual(144.261, res);

        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double res = ds.Calculate(x);
            Assert.AreEqual(Double.PositiveInfinity, res);

        }
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.5, res);

        }
        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -30.0;
            double res = ds.Calculate(x);
            Assert.AreEqual(600.033, res);

        }
    }
}
