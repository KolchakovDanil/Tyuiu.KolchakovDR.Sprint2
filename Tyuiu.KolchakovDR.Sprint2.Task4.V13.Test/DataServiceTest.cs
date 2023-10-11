using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint2.Task4.V13.Lib;

namespace Tyuiu.KolchakovDR.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        //Написать программу, которая вычисляет требуемое значение с использованием тернарного оператора,
        //где пользователь вводит значение переменных х,у с клавиатуры,
        //если
        //√х* 3 > y* 2 - 20, то z = x + 10 * y - (1 / x)
        //иначе
        //(x^2 + cos(y)^2 + 13)/(y^2 - sin(y)^2 + 9) 
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2; // -16
            double z = 20; // 1 + 10 * 2 - (1/1) = 1+20-1=20
            double res = ds.Calculate(x,y);
            Assert.AreEqual(z, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1.21; // 1.1 * 3 = 3.3
            double y = 12; // 24-20 = 4
            double z = 0.099; // (1.21^2 + cos(12)^2 + 13)/(12^2 - sin(12)^2 + 9) = 0.0993... => 0.099 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
