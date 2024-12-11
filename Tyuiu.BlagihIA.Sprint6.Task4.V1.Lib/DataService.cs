using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BlagihIA.Sprint6.Task4.V1.Lib
{
    public class DataService : ISprint6Task4V1
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
                if (x + 1.2 == 0)
                {
                    vArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round((Math.Sin(x) / (x + 1.2)) - (Math.Cos(x) * 7 * x) - 2, 2);
                    vArray[count] = y;
                    count++;
                }
            }
            return vArray;
        }
    }
}
