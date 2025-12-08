using Tyuiu.BaturinaSA.Sprint5.Task2.V11.Lib;

namespace Tyuiu.BaturinaSA.Sprint5.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\kmert\AppData\Local\Temp\OutPutFileTask1";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
