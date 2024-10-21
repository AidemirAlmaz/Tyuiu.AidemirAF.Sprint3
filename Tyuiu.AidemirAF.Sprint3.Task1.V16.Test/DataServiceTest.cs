using Tyuiu.AidemirAF.Sprint3.Task1.V16.Lib;

namespace Tyuiu.AidemirAF.Sprint3.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 2;
            
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 3.858;
            Assert.AreEqual(wait, res);
        }
    }
}