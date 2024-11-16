using Tyuiu.AidemirAF.Sprint3.Task3.V22.Lib;

namespace Tyuiu.AidemirAF.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "abcaaaa";
            char item = 'a';
            double res = ds.GetMaxCharCount(value, item);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}