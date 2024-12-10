using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BlagihIA.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (var k = 0; k < matrix.GetLength(1); k++)
                    {

                        if (matrix[i, j] <= matrix[k, j])
                        {
                            var temp = matrix[i, j];
                            matrix[i, j] = matrix[k, j];
                            matrix[k, j] = temp;
                        }
                    }
                }
            }

            return matrix;

        }
    }
}

