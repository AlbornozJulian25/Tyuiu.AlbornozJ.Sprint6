using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.AlbornozJ.Sprint6.Task4.V9.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task4.V9.Test
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

            
            double[] resultArray = ds.GetMassFunction(startValue, stopValue);

            
            double[] waitArray = (double[])resultArray.Clone();

            
            CollectionAssert.AreEqual(waitArray, resultArray, "Массивы не совпадают");

            
            System.Diagnostics.Debug.WriteLine("Valores calculados:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine($"x = {startValue + i}: {resultArray[i]}");
            }
        }
    }
}
