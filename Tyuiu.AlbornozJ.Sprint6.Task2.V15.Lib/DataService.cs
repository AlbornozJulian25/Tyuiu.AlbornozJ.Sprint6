using System;


using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlbornozJ.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                
                if (Math.Abs(3 * x + 1.2) < 0.0001) 
                {
                    y = 0;
                }
                else
                {
                    
                    
                    y = (2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 14 * x;
                    y = Math.Round(y, 2);
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
