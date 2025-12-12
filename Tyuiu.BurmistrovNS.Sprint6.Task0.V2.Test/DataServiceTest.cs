using Tyuiu.BurmistrovNS.Sprint6.Task0.V2.Lib;
namespace Tyuiu.BurmistrovNS.Sprint6.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 6.425;
            Assert.AreEqual(wait, res);
        }   
    }
}
