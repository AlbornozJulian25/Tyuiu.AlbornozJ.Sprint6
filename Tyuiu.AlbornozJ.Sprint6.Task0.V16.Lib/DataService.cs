using System;



using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlbornozJ.Sprint6.Task0.V16.Lib
{
    public class DataService : ISprint6Task0V16
    {
        public double Calculate(int x)
        {
            double y = (1 + Math.Pow(x, 3)) / Math.Pow(x, 2);
            return Math.Round(y, 3);
        }
    }
}
