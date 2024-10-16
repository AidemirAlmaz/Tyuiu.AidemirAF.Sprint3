using Tyuiu.AidemirAF.Sprint3.Task0.V13.Lib;

/*
 * ЗАДАНИЕ
 * Написать программу используя цикл for,
 * которая вычисляет сумму ряда по формуле, при а = 0,5.
 */

namespace Tyuiu.AidemirAF.Sprint3.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;
            Console.WriteLine("Переменная a = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
