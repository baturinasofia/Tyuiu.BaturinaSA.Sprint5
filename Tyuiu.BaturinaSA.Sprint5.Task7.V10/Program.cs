using Tyuiu.BaturinaSA.Sprint5.Task7.V10.Lib;

namespace Tyuiu.BaturinaSA.Sprint5.Task7.V10;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Батурина С. А. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Заменить все заглавные латинские буквы на строчные.                     *");
        Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V10.txt.       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V10.txt");
        string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V10.txt");
        Console.WriteLine("Данные находятся в файле:" + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Находится в файле:");

        pathSaveFile = ds.LoadDataAndSave(path);

        Console.WriteLine(pathSaveFile);
        Console.ReadKey();
    }
}