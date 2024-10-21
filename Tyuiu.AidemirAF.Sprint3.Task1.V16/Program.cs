using Tyuiu.AidemirAF.Sprint3.Task1.V16.Lib;

/*
 * ЗАДАНИЕ
 * Написать программу используя цикл while,
 * которая вычисляет сумму ряда по формуле, при х = 0,7
 */

namespace Tyuiu.AidemirAF.Sprint3.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            double value = 0.7;
            int startValue = 1;
            int stopValue = 15;
            Console.WriteLine("Переменная x = " + value);
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
