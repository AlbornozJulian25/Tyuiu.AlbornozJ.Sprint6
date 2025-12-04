using Microsoft.VisualStudio.TestTools.UnitTesting;


using Tyuiu.AlbornozJ.Sprint6.Task1.V4.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);
                        
            Assert.AreEqual(11, result.Length);                      
            Assert.AreEqual(7.83, result[0]);              
            Assert.AreEqual(0, result[5]);            
            Assert.AreEqual(-5.53, result[7]);             
            Assert.AreEqual(-8.24, result[10]);
        }

        [TestMethod]
        public void ValidDivisionByZero()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-2, -1);
                        
            Assert.AreEqual(-0.52, result[1]); // x = -1
        }
    }
}