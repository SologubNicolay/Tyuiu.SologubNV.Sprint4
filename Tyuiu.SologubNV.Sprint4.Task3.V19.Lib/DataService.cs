using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SologubNV.Sprint4.Task3.V19.Lib
{
    public class DataService : ISprint4Task3V19
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;
            int sum = 0;
            for (int i = 0;  i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        sum ++;
                    }
                }
            }
            return sum;
        }
    }
}
