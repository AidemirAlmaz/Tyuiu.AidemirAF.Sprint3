using Tyuiu.AidemirAF.Sprint3.Task3.V22.Lib;

/*
 * ЗАДАНИЕ
 * Используя цикл foreach подсчитать максимальное количество букв b, 
 * находящихся на соседних позициях в строке: tbtbbb dsfbg bbg
 */

namespace Tyuiu.AidemirAF.Sprint3.Task3.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            string value = "tbtbbb dsfbg bbg";
            char item = 'b';
            Console.WriteLine("Исходная строка:" + value);
            Console.WriteLine("Искомый результат:" + item);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Количество символов = " + ds.GetMaxCharCount(value, item));
            Console.ReadKey();
        }
    }
}
