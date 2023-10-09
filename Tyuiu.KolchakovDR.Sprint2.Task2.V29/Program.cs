using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint2.Task2.V29.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint2.Task2.V29
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
                "Оператор if – полная и короткая форма записи",
                2,
                29,
                "Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет находится ли точка с координатами X,Y в заштрихованной области.");
            thg.printHeader();

            Console.WriteLine("Введите координату X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);

            thg.printFooter();

            if (res)
            {
                Console.WriteLine("Точка в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
