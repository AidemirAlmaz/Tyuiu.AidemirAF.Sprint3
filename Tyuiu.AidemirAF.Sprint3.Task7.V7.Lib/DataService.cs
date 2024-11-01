using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AidemirAF.Sprint3.Task7.V7.Lib
{
    public class DataService : ISprint3Task7V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; //объявляем пустой массив
            int len = (stopValue - startValue) + 1; //вычисляем длину массива
            valueArray = new double[len]; //создаем массив с указанной длиной
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != -2)
                {
                    y = Math.Round(Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x, 2); //округляем значение до 2 знаков после запятой
                    valueArray[count] = y; //присваиваем значение в массив с индексом count
                    count++;
                }
                else
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
