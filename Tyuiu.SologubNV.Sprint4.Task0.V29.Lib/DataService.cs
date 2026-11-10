using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SologubNV.Sprint4.Task0.V29.Lib
{
    public class DataService : ISprint4Task0V29
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
