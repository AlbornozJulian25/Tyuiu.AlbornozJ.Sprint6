using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using Tyuiu.AlbornozJ.Sprint6.Task7.V21.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            
            string tempPath = Path.GetTempFileName().Replace(".tmp", ".csv");
            string testData = "2;3;3;14;2;3;0;4\n0;8;0;20;2;10;0;4\n1;2;0;3;2;3;0;4";
            File.WriteAllText(tempPath, testData);

            int[,] res = ds.GetMatrix(tempPath);

            
            Assert.AreEqual(-1, res[0, 7]); 
            Assert.AreEqual(-1, res[1, 7]); 
            Assert.AreEqual(-1, res[2, 7]); 

            File.Delete(tempPath);
        }

        [TestMethod]
        public void ValidKeepFive()
        {
            DataService ds = new DataService();

            string tempPath = Path.GetTempFileName().Replace(".tmp", ".csv");
            string testData = "1;2;3;4;5;6;7;5\n1;2;3;4;5;6;7;8";
            File.WriteAllText(tempPath, testData);

            int[,] res = ds.GetMatrix(tempPath);

            
            Assert.AreEqual(5, res[0, 7]);
            
            Assert.AreEqual(-1, res[1, 7]);

            File.Delete(tempPath);
        }
    }
}
