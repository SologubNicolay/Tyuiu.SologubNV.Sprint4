using Tyuiu.SologubNV.Sprint4.Task7.V4.Lib;
namespace Tyuiu.SologubNV.Sprint4.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = "382976421897";
            int rows = 3;
            int cols = 4;
            int res = ds.Calculate(rows, cols, a);
            int wait = 6;
            Assert.AreEqual(wait,res);
        }
    }
}
