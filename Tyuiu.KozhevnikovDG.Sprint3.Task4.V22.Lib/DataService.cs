using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KozhevnikovDG.Sprint3.Task4.V22.Lib
{
    public class DataService : ISprint3Task4V22
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x<= stopValue; x++)
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res = res + (x / ((Math.Sin(x) - x)));
                }
            return Math.Round(res, 3);
        }
    }
}
