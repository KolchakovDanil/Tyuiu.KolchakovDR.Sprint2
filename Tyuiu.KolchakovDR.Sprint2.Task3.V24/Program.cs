using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint2.Task3.V24.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint2.Task3.V24
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
                "Вложенные операторы if - else",
                3,
                24,
                "Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных оператор if-else, где пользователь вводит значение переменной X с клавиатуры. Округлить полученное значение до трех знаков после запятой.");
            thg.printHeader();

            Console.WriteLine("Введите значение числа X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("Формула: x * ((10 + sin√(x+1)) / x)^x ");
            }
            else if (x == 0)
            {
                Console.WriteLine(" Формула: cosx + 12 / x^2 ");
                Console.WriteLine("(при делении числа на 0, значение равно бесконечности)");
            }
            else if ((-28 < x) && (x < 0))
            {
                Console.WriteLine("Формула: (1 + 1/ x^2)^x ");
            }
            else if (x < -28)
            {
                Console.WriteLine("Формула: x^2 + 10 * x - (1/x) ");
            }
            else
            {
                Console.WriteLine("Не существующее значение Х!");
            }
            thg.printFooter();
            double res = ds.Calculate(x);
            Console.WriteLine("Y = " + res);
            Console.ReadKey();

        }

    }
}
