using Tyuiu.BaturinaSA.Sprint5.Task1.V1.Lib;
using System.IO;

namespace Tyuiu.BaturinaSA.Sprint5.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Батурина С.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант 1                                                               *");
            Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано функция, произвести табуляцию на диапазоне [-5;5] с шагом 1.       *");
            Console.WriteLine("* Произвести проверку деления на 0. При делении на ноль вернуть значение  *");
            Console.WriteLine("* 0. Результат сохранить в текстовый файл OutPutFileTask0.txt и вывести   *");
            Console.WriteLine("* на консоль в таблицу. Значения окрулить до двух знаков после запятой.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            for (int x = startValue; x <= stopValue; x++)
            {
                double znam = Math.Sin(x) + 2;
                double y;

                if (znam == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((5 * x + 2.5) / (znam)) + (2 * x) + 2;
                    y = Math.Round(y, 3);
                }

                Console.WriteLine($"| {x,6}  | {y,8} |");
            }
            Console.WriteLine("Файл создан по пути: " + path);
            Console.ReadKey();
        }
    }
}