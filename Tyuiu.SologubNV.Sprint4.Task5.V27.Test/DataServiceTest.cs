using Tyuiu.SologubNV.Sprint4.Task5.V27.Lib;
namespace Tyuiu.SologubNV.Sprint4.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { -1, 2, 3, 4, 5 }, { -1, 2, 3, 4, 5 }, { -1, 2, 3, 4, 5 }, { -1, 2, 3, 4, 5 }, { -1, 2, 3, 4, 5 } };
            int res = ds.Calculate(array);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
