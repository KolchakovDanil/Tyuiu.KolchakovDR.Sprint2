using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint2.Task6.V5.Lib;
namespace Tyuiu.KolchakovDR.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardValue()
        {
            DataService ds = new DataService();
            int card = 6;
            var res = ds.FindCardValue(card);
            Assert.AreEqual("Шестёрка", res);
        }
    }
}
