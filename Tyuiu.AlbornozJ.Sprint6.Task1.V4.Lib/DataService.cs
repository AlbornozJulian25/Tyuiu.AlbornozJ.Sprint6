using System;



using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlbornozJ.Sprint6.Task1.V4.Lib
{
    public class DataService : ISprint6Task1V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];

            for (int x = startValue, index = 0; x <= stopValue; x++, index++)
            {
                // Проверка деления на ноль
                if (x + 1.2 == 0)
                {
                    valueArray[index] = 0;
                }
                else
                {
                    // F(x) = sin(x)/(x+1.2) - sin(x)*2 - 2x
                    double numerator = Math.Sin(x);
                    double denominator = x + 1.2;
                    double term1 = numerator / denominator;
                    double term2 = Math.Sin(x) * 2;
                    double term3 = 2 * x;

                    valueArray[index] = Math.Round(term1 - term2 - term3, 2);
                }
            }

            return valueArray;
        }
    }
}
