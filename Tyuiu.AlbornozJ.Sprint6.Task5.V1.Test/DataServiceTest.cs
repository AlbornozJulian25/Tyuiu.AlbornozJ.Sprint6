using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using Tyuiu.AlbornozJ.Sprint6.Task5.V1.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V1.txt";

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 3.141, 2.718, 0.5, 4.2, 1.618, 5.0, 2.0, 3.0 };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint6\InPutFileTask5V1.txt";
            Assert.IsTrue(File.Exists(path));
        }
    }
}
