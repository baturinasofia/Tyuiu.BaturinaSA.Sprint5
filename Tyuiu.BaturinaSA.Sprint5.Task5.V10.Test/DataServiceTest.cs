using Tyuiu.BaturinaSA.Sprint5.Task5.V10.Lib;

namespace Tyuiu.BaturinaSA.Sprint5.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\0\AppData\Local\Temp\InPutDataFileTask5V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
