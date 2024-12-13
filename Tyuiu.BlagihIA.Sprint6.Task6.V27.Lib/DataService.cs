using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string path)
        {
            string strx = File.ReadAllText(path);
            string[] words = strx.Split(' ');

            string res ="";
            char item = 'H';
            foreach (var word in words)

            {
                if (word.Contains(item))
                {
                    res += " " + word;

                 }
            }

            return res;
        }
    }
}
