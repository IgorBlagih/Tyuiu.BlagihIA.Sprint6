using Tyuiu.BlagihIA.Sprint6.Task6.V27.Lib;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask6V27.txt");

            string res = ds.CollectTextFromFile(path);

            string wait = "Hello";

            Assert.AreEqual(wait, res);

        }
    }
}