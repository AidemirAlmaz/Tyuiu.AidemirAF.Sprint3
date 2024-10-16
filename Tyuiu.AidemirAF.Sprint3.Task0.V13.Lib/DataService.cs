using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AidemirAF.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double a = 0.5;
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + (Math.Pow(a, i) + (0.5)) * Math.Cos(i); 
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
