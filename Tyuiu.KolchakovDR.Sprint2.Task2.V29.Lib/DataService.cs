using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolchakovDR.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int[] verticalBoundaries  = {3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 11, 11, 11, 11, 11, 12, 12, 12};
            int[] horizontalBoundaries = {3, 4, 5, 9, 10, 11, 12, 1, 2, 3, 4, 5, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 6, 10, 11, 12, 13, 6, 10, 11, 12, 6, 10, 11, 12, 3, 4, 5, 6, 10, 11, 12, 4, 5, 10};

            for (int i = 0; i < horizontalBoundaries.Length; i++)
            {
                if (horizontalBoundaries[i]==x && verticalBoundaries[i]==y)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
