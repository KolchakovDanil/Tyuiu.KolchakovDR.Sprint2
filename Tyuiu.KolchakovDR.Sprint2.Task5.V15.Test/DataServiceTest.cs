using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint2.Task5.V15.Lib;

namespace Tyuiu.KolchakovDR.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int k = 13;
            var res = ds.FindDayName(k);
            Assert.AreEqual("Суббота", res);
        }
    }
}
