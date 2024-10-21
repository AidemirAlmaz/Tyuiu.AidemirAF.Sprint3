using Tyuiu.AidemirAF.Sprint3.Task2.V20.Lib;

namespace Tyuiu.AidemirAF.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 0;
            int stopValue = 1;
            
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1.923;
            Assert.AreEqual(wait, res);
        }
    }
}