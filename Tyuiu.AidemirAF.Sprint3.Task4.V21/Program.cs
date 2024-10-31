using Tyuiu.AidemirAF.Sprint3.Task4.V21.Lib;

/*
 * ЗАДАНИЕ
 * На отрезке, где х принимает значения от -5 до 5,
 * вычислить значение функции у = (cos(х) - х)/x
 * При х = 0 пропустить значение. Полученные значения перемножать
 */

namespace Tyuiu.AidemirAF.Sprint3.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
