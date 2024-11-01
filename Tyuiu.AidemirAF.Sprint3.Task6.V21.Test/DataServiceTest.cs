using Tyuiu.AidemirAF.Sprint3.Task6.V21.Lib;

namespace Tyuiu.AidemirAF.Sprint3.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 0;
            int stopValue = 1;
            double wait = 1;
            double res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}