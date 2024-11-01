using Tyuiu.AidemirAF.Sprint3.Task7.V7.Lib;

/*
 * ЗАДАНИЕ
 * Написать программу, которая выводит таблицу значений функции:
 *                  cos(x)
 * F(x) = cos(x) + ------- - 3x (произвести табулирование)
 *                  x + 2 
 * f(x) на заданном диапозоне [-5;5] с шагом 1.
 * Произвести проверку деления на ноль. При делении на ноль вернуть значение 0.
 * Значения оркуглить до двух знаков после запятой.
 */

namespace Tyuiu.AidemirAF.Sprint3.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            int startValue = 19;
            int stopValue = 30;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("+-------+----------+");
            Console.WriteLine("|   X   |    f(x)  |");
            Console.WriteLine("+-------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}  |  {1, 5:f2}  |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+-------+----------+");
            Console.ReadKey();
        }
    }
}
