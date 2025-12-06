using Microsoft.VisualStudio.TestTools.UnitTesting;


using Tyuiu.AlbornozJ.Sprint6.Task2.V15.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;

            double[] waitArray = new double[len];

            
            double[] resultArray = ds.GetMassFunction(startValue, stopValue);

            
            for (int i = 0; i < len; i++)
            {
                waitArray[i] = resultArray[i];
            }

            
            CollectionAssert.AreEqual(waitArray, resultArray, "Массивы не совпадают");

        }
    }
}
