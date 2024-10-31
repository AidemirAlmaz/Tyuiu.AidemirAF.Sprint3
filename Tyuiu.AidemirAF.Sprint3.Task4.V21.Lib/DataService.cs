using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AidemirAF.Sprint3.Task4.V21.Lib
{
    public class DataService : ISprint3Task4V21
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res = res * (((Math.Cos(x) - x)) / x);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
