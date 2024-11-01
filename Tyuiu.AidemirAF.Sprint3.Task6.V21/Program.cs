using Tyuiu.AidemirAF.Sprint3.Task6.V21.Lib;

/*
 * ЗАДАНИЕ
 * Напишите программу, которая ищет среди целых чисел,
 * принадлежащих отрезку [19,30] сумму всех делителей
 */

namespace Tyuiu.AidemirAF.Sprint3.Task6.V21
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

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
