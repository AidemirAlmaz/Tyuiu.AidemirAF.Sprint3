using Tyuiu.AidemirAF.Sprint3.Task7.V7.Lib;

namespace Tyuiu.AidemirAF.Sprint3.Task7.V7.Test
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
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 1.5;
            valueWaitArray[1] = -2.28;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}