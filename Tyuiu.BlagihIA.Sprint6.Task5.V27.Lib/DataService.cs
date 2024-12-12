using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using StreamReader reader = new StreamReader(path);
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] vArray = new double[len];

            int index = 0;
            using (StreamReader reader1 = new StreamReader(path))
            {
                string line;
                while ((line = reader1.ReadLine()) != null)
                {
                    vArray[index] = Math.Round(Convert.ToDouble(line),3);
                    index++;
                }
            }
            vArray = vArray.Where(val =>((val%5)!=0)).ToArray();
            return vArray;
        }
    }
}
