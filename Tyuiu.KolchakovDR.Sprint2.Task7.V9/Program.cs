using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint2.Task7.V9.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint2.Task7.V9
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
                "Добавление к решению итоговых проектов по спринту",
                7,
                9,
                "Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.");
            thg.printHeader();

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);

            thg.printFooter();
            Console.WriteLine($"Результат {res}");

            Console.ReadKey();
        }
    }
}
