using Tyuiu.AidemirAF.Sprint3.Task4.V21.Lib;

namespace Tyuiu.AidemirAF.Sprint3.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 2;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 0.555;
            Assert.AreEqual(wait, res);

        }
    }
}