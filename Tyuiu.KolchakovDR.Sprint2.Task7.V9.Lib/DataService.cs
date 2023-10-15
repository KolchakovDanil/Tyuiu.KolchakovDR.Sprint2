using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolchakovDR.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool y1 = Math.Sin(x) <= 0.5;
            bool y2 = y >= 0.5;
            bool res;
            if (y1 && y2)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
