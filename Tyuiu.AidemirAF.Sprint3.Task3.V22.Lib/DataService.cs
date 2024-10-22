using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AidemirAF.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            foreach (char c in value)
            {
                if (c == item) 
                {
                    count++;
                }
            }
            return count;
        }
    }
}
