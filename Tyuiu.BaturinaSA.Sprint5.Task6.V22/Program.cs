using Tyuiu.BaturinaSA.Sprint5.Task6.V22.Lib;

namespace Tyuiu.BaturinaSA.Sprint5.Task6.V22;

class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Батурина С. А. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти количество удвоенных букв \"мм\" в заданной строке.               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\Users\Софья\source\repos\Tyuiu.BaturinaSA.Sprint5\Tyuiu.BaturinaSA.Sprint5.Task6.V20\bin\Debug\net8.0\OutPutDataFileTask5V10.txt";

        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine("Сумма элементов файла: " + res);
        Console.ReadKey();
    }
}
