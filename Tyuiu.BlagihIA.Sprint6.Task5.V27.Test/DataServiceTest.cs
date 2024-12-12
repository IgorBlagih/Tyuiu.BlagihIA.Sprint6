using Tyuiu.BlagihIA.Sprint6.Task5.V27.Lib;
using System.IO;
using System.ComponentModel.DataAnnotations;
namespace Tyuiu.BlagihIA.Sprint6.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask5V27.txt");

            double[] vArray = new double[ds.len];
            vArray = ds.LoadFromDataFile(path);
                    
            double[] wait = {-3,4,34,-9,89};
            
            CollectionAssert.AreEqual(wait, vArray);

        }
    }
}