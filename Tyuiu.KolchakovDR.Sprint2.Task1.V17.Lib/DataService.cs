using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolchakovDR.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        //Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность 
        //можно чередовать, но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, 
        //последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет 
        //логическую последовательность(массив): (True, False, True, True, True, False), при a = 135, b = 123, c = 455, d = 321

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c < d); //true
            res[1] = (a > b) & (c - 135 > d); //false
            res[2] = (a > b + 12) || (c > d); //true
            res[3] = (a > b) && (c > d); //true
            res[4] = !res[1]; //true
            res[5] = (a > b) ^ (c > d); //false
            return res;
        }
    }
}
