using System;
using System.IO;


using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlbornozJ.Sprint6.Task7.V21.Lib
{
    public class DataService : ISprint6Task7V21
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            
            int[,] matrix = new int[rows, columns];

            
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            
            int targetColumn = 7; 

            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, targetColumn] != 5)
                {
                    matrix[r, targetColumn] = -1;
                }
            }

            return matrix;
        }
    }
}
