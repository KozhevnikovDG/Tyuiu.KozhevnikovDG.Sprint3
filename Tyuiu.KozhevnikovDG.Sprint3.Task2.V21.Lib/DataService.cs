using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KozhevnikovDG.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            do
            {

                sumSeries = sumSeries + ((Math.Pow((1) / (Math.Sin(startValue) + 2 * Math.Pow(value, startValue)), startValue)));
                startValue++;

            } while (startValue <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
