using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolchakovDR.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int value)
        {
            string res = "";
            if (1 <= value && value <= 365)
            {
                switch (value % 7)
                {
                    case 1: res = "Понедельник"; break;
                    case 2: res = "Вторник"; break;
                    case 3: res = "Среда"; break;
                    case 4: res = "Четверг"; break;
                    case 5: res = "Пятница"; break;
                    case 6: res = "Суббота"; break;
                    case 0: res = "Воскресенье"; break;

                }
                return res;
            }
            throw new ArgumentException($"День должен находиться в диапозоне от 1 до 365. Значение {value}");
        }
    }
}
