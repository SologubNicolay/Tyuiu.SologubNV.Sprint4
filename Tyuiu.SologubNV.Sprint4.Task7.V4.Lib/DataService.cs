using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SologubNV.Sprint4.Task7.V4.Lib
{
    public class DataService : ISprint4Task7V4
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0;
            int[,] array = new int[n, m];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(value[i * m + j].ToString());
                    if (array[i, j] % 2 == 1)
                    {
                        sum += 1;
                    }
                }

            }
            return sum;
        }
    }
}
