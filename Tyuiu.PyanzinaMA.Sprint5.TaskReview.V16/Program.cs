using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyanzinaMA.Sprint5.TaskReview.V16.Lib;
using System.IO;

namespace Tyuiu.PyanzinaMA.Sprint5.TaskReview.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Пьянзина М. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Sprint Review                                                     *");
            Console.WriteLine("* Задание #TaskReview                                                     *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Пьянзина Мария Алексеевна | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Заменить все слова     *");
            Console.WriteLine("* длиной 2 символа на слово XY. Полученный результат сохранить в файл     *");
            Console.WriteLine("* OutPutDataFileTask7V16.txt.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSptint5\InPutDataFileTask7V16.txt";
            Console.WriteLine("Исходные данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = @"C:\Users\User\source\repos\Tyuiu.PyanzinaMA.Sprint5.Review\Tyuiu.PyanzinaMA.Sprint5.TaskReview.V16\bin\Debug\OutPutDataFileTask7V16.txt";
            Console.WriteLine("Конечные данные находятся в файле: " + pathSaveFile);

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.ReadKey();
        }
    }
}
