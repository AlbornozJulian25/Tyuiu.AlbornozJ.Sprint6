using Microsoft.VisualStudio.TestTools.UnitTesting;






using Tyuiu.AlbornozJ.Sprint6.Task0.V16.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(3);
            double wait = 3.111;
            Assert.AreEqual(wait, result);
        }
    }
}
