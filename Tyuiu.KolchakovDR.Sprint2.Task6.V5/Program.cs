using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint2.Task6.V5.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint2.Task6.V5
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
                "Получение результата из switch",
                6,
                5,
                "Написать программу, которая использует сокращенную форму записи оператора switch вычисляет требуемое значение и возвращает результат. Условие: Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.Порядковые номера остальных карт соответствуют их названиям(«шестерка», «девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство соответствующей карты.");
            thg.printHeader();
            Console.WriteLine("Введите номер карты: ");
            int card = Convert.ToInt32(Console.ReadLine());
            thg.printFooter();
            string res = ds.FindCardValue(card);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
