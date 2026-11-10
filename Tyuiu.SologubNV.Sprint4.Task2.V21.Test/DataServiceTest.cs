using Tyuiu.SologubNV.Sprint4.Task2.V21.Lib;
namespace Tyuiu.SologubNV.Sprint4.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4 };
            int res = ds.Calculate(array);
            int wait = 2 * 4 * 2 * 4;
            Assert.AreEqual(wait,res);
        }
    }
}
