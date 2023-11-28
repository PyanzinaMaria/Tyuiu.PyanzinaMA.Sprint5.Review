using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyanzinaMA.Sprint5.TaskReview.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\User\source\repos\Tyuiu.PyanzinaMA.Sprint5.Review\Tyuiu.PyanzinaMA.Sprint5.TaskReview.V16\bin\Debug\OutPutDataFileTask7V16.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string lines = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] == ' ') && (line[i + 1] != ' ') && (line[i + 2] != ' ') && (line[i + 3] == ' '))
                        {
                            lines = lines + line[i] + "XY";
                            i = i + 2;
                        }
                        else
                        {
                            lines = lines + line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, lines + Environment.NewLine);
                    lines = "";
                }
            }
            
            return pathSaveFile;
        }
    }
}
