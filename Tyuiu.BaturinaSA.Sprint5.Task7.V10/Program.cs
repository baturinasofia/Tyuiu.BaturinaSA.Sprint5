using Tyuiu.BaturinaSA.Sprint5.Task7.V10.Lib;

namespace Tyuiu.BaturinaSA.Sprint5.Task7.V10;

    internal class Program
    {
       static void Main(string[] args)
       {
           DataService ds = new DataService();

           Console.WriteLine("***************************************************************************");
           Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
           Console.WriteLine("***************************************************************************");

           string path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";
           string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");

           Console.WriteLine("Данные находятся в файле: " + path);

           Console.WriteLine("***************************************************************************");
           Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
           Console.WriteLine("***************************************************************************");

           Console.WriteLine("Находится в файле: ");
           pathSaveFile = ds.LoadDataAndSave(path);
           Console.WriteLine(pathSaveFile);

           Console.ReadKey();
       }
    }