using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolchakovDR.Sprint2.Task4.V13.Lib
{
    public class DataService : ISprint2Task4V13
    {
        public double Calculate(double x, double y)
        {
            double z = 0;

            if (Math.Sqrt(x) * 3 > y * 2 - 20) //то z = x + 10 * y - (1 / x)
            {
                z = Math.Round(x + 10 * y - (1/x), 3);
            }
            else // иначе (x^2 + cos(y)^2 + 13)/(y^2 - sin(y)^2 + 9) 
            {
                z = Math.Round((Math.Pow(x,2) + Math.Pow(Math.Cos(y), 2) + 13)/(Math.Pow(y, 2) - Math.Pow(Math.Sin(y),2) + 9) , 3);
            }
            return z;
        }
    }
}
