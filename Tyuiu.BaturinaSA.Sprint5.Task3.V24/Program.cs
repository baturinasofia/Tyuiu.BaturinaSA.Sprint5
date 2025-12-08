using Tyuiu.BaturinaSA.Sprint5.Task3.V24.Lib;

namespace Tyuiu.BaturinaSA.Sprint5.Task3.V24;
class Program
{
    static void Main(string[] args)
    {
        int x = 3;

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Батурина С. А. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3                         *");
        Console.WriteLine("* результат сохранить в бинарный файл и вывести на консоль.               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("x = " + x);

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);

        double fileValue;
        using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
        {
            fileValue = reader.ReadDouble();
        }

        string resultFromFile = File.ReadAllText(res);

        Console.WriteLine("Результат:" + fileValue.ToString("F3"));
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}