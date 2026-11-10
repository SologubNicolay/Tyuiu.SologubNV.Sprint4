using Tyuiu.SologubNV.Sprint4.Task0.V29.Lib;
namespace Tyuiu.SologubNV.Sprint4.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetSumOddArrEl(numArray);
            int wait = 7 + 3 + 1 + 5 + 9 + 7;
            Assert.AreEqual(wait,res);
        }
    }
}
