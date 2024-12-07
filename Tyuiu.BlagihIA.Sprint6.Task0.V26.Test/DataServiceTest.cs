using Tyuiu.BlagihIA.Sprint6.Task0.V26.Lib;
namespace Tyuiu.BlagihIA.Sprint6.Task0.V26
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 

            int x = 0;
            double wait = 0.25;
            double res = ds.Calculate(x);

            Assert.AreEqual(wait, res);

        }
    }
}