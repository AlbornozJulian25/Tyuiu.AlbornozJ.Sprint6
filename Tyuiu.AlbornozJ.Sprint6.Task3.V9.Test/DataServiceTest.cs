using Microsoft.VisualStudio.TestTools.UnitTesting;


using Tyuiu.AlbornozJ.Sprint6.Task3.V9.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSortMatrix()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { -14, 25, 26, 18, 17 },
                { 28, 10, 6, -2, 4 },
                { 30, 25, -3, 11, -10 },
                { 11, 32, -5, -20, 25 },
                { 2, -18, 11, 8, -20 }
            };

            int[,] res = ds.Calculate(matrix);

            
            int[] fifthColumn = new int[5];
            for (int i = 0; i < 5; i++)
            {
                fifthColumn[i] = res[i, 4];
            }

            
            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(fifthColumn[i] <= fifthColumn[i + 1],
                    $"Пятый столбец не отсортирован: {fifthColumn[i]} > {fifthColumn[i + 1]}");
            }
        }
    }
}
