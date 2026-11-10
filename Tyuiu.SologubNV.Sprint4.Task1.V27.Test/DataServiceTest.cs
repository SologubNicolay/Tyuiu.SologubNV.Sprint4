using Tyuiu.SologubNV.Sprint4.Task1.V27.Lib;
namespace Tyuiu.SologubNV.Sprint4.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 8 * 4 * 4 * 2;
            int[] array = { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5 };
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
