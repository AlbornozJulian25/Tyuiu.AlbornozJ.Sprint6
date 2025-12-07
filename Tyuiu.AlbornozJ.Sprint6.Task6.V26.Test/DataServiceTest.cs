using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using Tyuiu.AlbornozJ.Sprint6.Task6.V26.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V26.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "программирования увлекательно разработки платформа полезны важно данными интерфейсов";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V26.txt";
            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void CheckEmptyFile()
        {
            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "");

            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(tempPath);

            Assert.AreEqual("", res);
            File.Delete(tempPath);
        }
    }
}
