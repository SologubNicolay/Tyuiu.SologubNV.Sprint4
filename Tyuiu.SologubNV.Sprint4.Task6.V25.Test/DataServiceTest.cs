using Tyuiu.SologubNV.Sprint4.Task6.V25.Lib;
namespace Tyuiu.SologubNV.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] ar = ["Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей"];
            int res = ds.Calculate(ar);
            int wait = 2;
            Assert.AreEqual(wait,res);
        }
    }
}
