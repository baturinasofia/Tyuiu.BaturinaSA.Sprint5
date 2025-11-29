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
            string path = @"C:\Users\Софья\source\repos\Tyuiu.BaturinaSA.Sprint5\Tyuiu.BaturinaSA.Sprint5.Task1.V1\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
