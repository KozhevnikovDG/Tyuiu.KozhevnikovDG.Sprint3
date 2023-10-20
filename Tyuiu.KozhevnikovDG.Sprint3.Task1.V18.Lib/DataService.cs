using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KozhevnikovDG.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            while(startValue <= stopValue)
            {
                sumSeries = sumSeries + Math.Sin(startValue) * Math.Pow((0.25), 2);
                startValue++;
            }
            return Math.Round(sumSeries,3);
        }
    }
}
