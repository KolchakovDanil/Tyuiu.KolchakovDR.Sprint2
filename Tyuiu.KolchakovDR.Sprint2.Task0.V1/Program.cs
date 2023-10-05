using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint2.Task0.V1.Lib;
using TaskHeaderGenerator;
namespace Tyuiu.KolchakovDR.Sprint2.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            TaskHG thg = new TaskHG(
                2,
                "Колчаков Д. Р.",  
                "ИИПб-23-2",
                "Операции сравнения",
                0,
                1,
                "Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, False, True, False), при x = 233, y = 122");
            thg.printHeader();
            int x = 233;
            int y = 122;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            thg.printFooter();
            
            for (int i=0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
