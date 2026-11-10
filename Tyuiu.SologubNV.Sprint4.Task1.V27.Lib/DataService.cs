using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SologubNV.Sprint4.Task1.V27.Lib
{
    public class DataService : ISprint4Task1V27
    {
        public int Calculate(int[] array)
        {
            int pr = 1;
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    pr *= i;
                }
            }
            return pr;
        }
    }
}
