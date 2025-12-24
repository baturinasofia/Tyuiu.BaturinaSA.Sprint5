using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BaturinaSA.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strline = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace('А', 'а').Replace('B', 'b').Replace('C', 'c').Replace('D', 'd').Replace('E', 'e').Replace('F', 'f').Replace('G', 'g').Replace('H', 'h').Replace('I', 'i').Replace('J', 'j').Replace('K', 'k').Replace('L', 'l').Replace('M', 'm').Replace('N', 'n').Replace('O', 'o').Replace('P', 'p').Replace('Q', 'q').Replace('R', 'r').Replace('S', 's').Replace('Т', 'т').Replace('U', 'u').Replace('V', 'v').Replace('W', 'w').Replace('X', 'x').Replace('Y', 'y').Replace('Z', 'z');
                    strline = line;
                }
                File.AppendAllText(pathSaveFile, strline + Environment.NewLine);
                strline = "";
            }
            return pathSaveFile;
        }
    }
}