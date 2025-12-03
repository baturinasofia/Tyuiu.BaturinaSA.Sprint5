using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.BaturinaSA.Sprint5.Task1.V1.Lib
{
    public class DataService : ISprint5Task1V1
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            double y;
            string strY = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double znam = Math.Sin(x) + 2;
                if (znam == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((5 * x + 2.5) / (znam)) + (2 * x) + 2;
                    y = Math.Round(y, 2);
                    strY = Convert.ToString(y);
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}