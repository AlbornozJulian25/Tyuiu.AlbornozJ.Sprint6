using System;


using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlbornozJ.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            
            int[,] resultMatrix = (int[,])matrix.Clone();

            
            int sortColumn = 4;

            
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (resultMatrix[j, sortColumn] > resultMatrix[j + 1, sortColumn])
                    {
                        
                        for (int k = 0; k < columns; k++)
                        {
                            int temp = resultMatrix[j, k];
                            resultMatrix[j, k] = resultMatrix[j + 1, k];
                            resultMatrix[j + 1, k] = temp;
                        }
                    }
                }
            }

            return resultMatrix;
        }
    }
}
