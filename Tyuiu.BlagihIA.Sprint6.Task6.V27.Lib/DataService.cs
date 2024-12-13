using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    foreach(var h in line.Split(' '))
                    {
                        if (h.Contains('H'))
                        {
                            res += " " + h;

                        }
                    }
                }
            }

            return res;
        }
    }
}
