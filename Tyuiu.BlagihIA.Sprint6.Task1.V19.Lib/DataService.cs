using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint6.Task1.V19.Lib
{
    public class DataService : ISprint6Task1V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
    
            double[] vArray;
            int len = (stopValue - startValue) + 1;
            vArray = new double[len];

            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2 == 0)
                {
                    vArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round((Math.Cos(x) + Math.Cos(x) / (x + 2) - 3 * x), 2);
                    vArray[count] = y;
                    count++;
                }
            }
            return vArray;
        }
    }
}
