using Tyuiu.AidemirAF.Sprint3.Task5.V30.Lib;

namespace Tyuiu.AidemirAF.Sprint3.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 0;
            int startValue2 = 0;
            int stopValue1 = 0;
            int stopValue2 = 0;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}