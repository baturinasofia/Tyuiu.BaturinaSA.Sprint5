using Tyuiu.BaturinaSA.Sprint5.Task1.V1.Lib;
using System.IO;

namespace Tyuiu.BaturinaSA.Sprint5.Task1.V1.Test
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
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
