using Tyuiu.BaturinaSA.Sprint5.Task6.V22.Lib;

namespace Tyuiu.BaturinaSA.Sprint5.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\0\AppData\Local\Temp\InPutDataFileTask6V122.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
