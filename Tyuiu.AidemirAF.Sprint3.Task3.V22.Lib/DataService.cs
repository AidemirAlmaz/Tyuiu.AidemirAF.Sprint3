using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AidemirAF.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {
            int res = 0;
            char[] ch = value.ToCharArray();
            foreach (char c in ch)
            {
                if (c == item)
                {
                    res++;
                }
                else
                {
                    res = 0;
                }
            }
            return res.Max();
        }
    }
}
