using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint2.Task5.V15.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint2.Task5.V15
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
                "Оператор switch",
                5,
                15,
                "Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат. Условие: Дано целое число k(1 <= k <= 365).Определить, каким днем недели(понедельником, вторником, …, субботой или воскресеньем) является k - й день не високосного года, в котором 1 января понедельник.");
            thg.printHeader();
            Console.WriteLine("Введите номер дня в году: ");
            int k = Convert.ToInt32(Console.ReadLine());
            thg.printFooter();
            string res = ds.FindDayName(k);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
