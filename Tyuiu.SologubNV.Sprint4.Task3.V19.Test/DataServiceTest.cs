using Tyuiu.SologubNV.Sprint4.Task3.V19.Lib;
namespace Tyuiu.SologubNV.Sprint4.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { {6, 5, 6, 3, 8 },
                                         {9, 4, 4, 3, 4},{3, 3, 6, 8, 6},{6, 5, 3, 4, 3},{9, 3, 5, 3, 7 }};
            int res = ds.Calculate(mas2);
            int wait = 11;
            Assert.AreEqual(wait, res);
            }
    }
}
