using Tyuiu.BaturinaSA.Sprint5.Task7.V10.Lib;

namespace Tyuiu.BaturinaSA.Sprint5.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Софья\source\repos\OutPutDataFileTask7V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}