using System.Diagnostics;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AidemirAF.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {
            int cnt = 0;
            int res = 0;
            int count = 0;
            int len = value.Length;
            char[] ch = value.ToCharArray();
            foreach (int c in ch)
            {
                if (cnt == len - 1)
                {
                    break;
                }
                if (c == 'b' && c + 1 == 'b')
                {
                    count += 1;
                }
                else
                {
                    if (res < count)
                    {
                        res = count;
                        count = 0;
                    }
                }
                cnt++;
                

            }
            return res;
        }
    }
}
