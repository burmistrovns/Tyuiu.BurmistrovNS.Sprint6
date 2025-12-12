using Tyuiu.BurmistrovNS.Sprint6.Task6.V27.Lib;
using System.IO;
namespace Tyuiu.BurmistrovNS.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Николай\source\repos\Tyuiu.BurmistrovNS.Sprint6\InPutFileTask6V27.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "UpGwjzkBH OHcr KgepHrKCHa";
            Assert.AreEqual(wait, res);
        }
    }
}