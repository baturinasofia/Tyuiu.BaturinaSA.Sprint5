using Tyuiu.BaturinaSA.Sprint5.Task0.V14.Lib;
using System;

namespace Tyuiu.BaturinaSA.Sprint4.Task0.V14
{

     class Program
     {
         static void Main(string[] args)
         {
                int x = 3;

                Console.Title = "Спринт #5 | Выполнила: Батурина С. А. | ИСТНб-25-1";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #5                                                               *");
                Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
                Console.WriteLine("* Задание #0                                                              *");
                Console.WriteLine("* Вариант #14                                                             *");
                Console.WriteLine("* Выполнила: Батурина Софья Алексеевна | ИСТНб-25-1                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
                Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль.                *");
                Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                DataService ds = new DataService();
                Console.WriteLine("x = " + x);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                string res = ds.SaveToFileTextData(x);

                Console.WriteLine("Файл: " + res);
                Console.WriteLine("Создан!");
                Console.ReadLine();
         }
     }
}