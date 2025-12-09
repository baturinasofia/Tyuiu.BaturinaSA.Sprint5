using Tyuiu.BaturinaSA.Sprint5.Task5.V10.Lib;
namespace Tyuiu.BaturinaSA.Sprint5.Task5.V10;

class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Батурина С. А. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти сумму всех четных целых чисел в файле.                            *");
        Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\Users\Софья\source\repos\Tyuiu.BaturinaSA.Sprint5\Tyuiu.BaturinaSA.Sprint5.Task5.V10\bin\Debug\net8.0\InPutDataFileTask5V10.txt";

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
