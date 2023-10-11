using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint2.Task4.V13.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint2.Task4.V13
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
                "Тернарный оператор",
                4,
                13,
                "Написать программу, которая вычисляет требуемое значение с использованием тернарного оператора, где пользователь вводит значение переменных X, Y с клавиатуры, если √х * 3 > y * 2 - 20, то z = x + 10 * y - (1 / x) иначе(x ^ 2 + cos(y) ^ 2 + 13) / (y ^ 2 - sin(y) ^ 2 + 9). Ответ округлите до 3 знаков после запятой.");
            thg.printHeader();
            Console.WriteLine("Введите значение числа X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение числа Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.Sqrt(x) * 3 > y * 2 - 20)
            {
                Console.WriteLine("Формула: z = x + 10 * y - (1 / x) ");
            }
            else 
            {
                Console.WriteLine(" Формула: (x^2 + cos(y)^2 + 13)/(y^2 - sin(y)^2 + 9) ");
            }

            thg.printFooter();
            double res = ds.Calculate(x,y);
            Console.WriteLine("Ответ = " + res);
            Console.ReadKey();
        }
    }
}
