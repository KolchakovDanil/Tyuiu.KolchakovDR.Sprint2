using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolchakovDR.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            string res = "";
            //if (6 <= value && value <= 14)
            //{
                switch (value)
                {
                    case 6: res = "Шестёрка"; break;
                    case 7: res = "Семёрка"; break;
                    case 8: res = "Восьмёрка"; break;
                    case 9: res = "Девятка"; break;
                    case 10: res = "Десятка"; break;
                    case 11: res = "Валет"; break;
                    case 12: res = "Дама"; break;
                    case 13: res = "Король"; break;
                    case 14: res = "Туц"; break;
                    default: res = "Определение карты должено находиться в диапозоне от 6 до 14. Значение " + value; break;
                }
                return res;
                
            //}
            //throw new ArgumentException($"Определение карты должено находиться в диапозоне от 6 до 14. Значение {value}");
        }
    }
}
