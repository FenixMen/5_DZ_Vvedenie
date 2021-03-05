using System;
using System.IO;



namespace _4
{

    class Program
    {//Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
        static string newDir = @"C:\tempDZ_5_Fenix\";

        static int TreadDir(int i, string[] arrayDir)
        {
            if (i == 0)
                return 0;
            else
            {
                i = TreadDir(--i, arrayDir);
                File.AppendAllText(newDir + "treadDirRecursive.txt", arrayDir[i] + "\n");
                return ++i;
            }
        }
        static void Main(string[] args)
        {
            
            string[] arrayDir = Directory.GetFileSystemEntries(@"C:\");
            Directory.CreateDirectory(newDir);

            //без рекурсии
            File.AppendAllLines(newDir + "treadDir.txt", arrayDir);
            Console.WriteLine($"Файлы созданы в дериктории '{newDir}'");

            //с рекурсией
            TreadDir(arrayDir.Length, arrayDir);




            Console.WriteLine("\nПрибрать за собой 'Хвосты'? 'Y' - да\nне забудьте закрыть текстовый фал " +
                              "перед этим, а то это еще куча кода, чтоб поймать исключение...");
            if(Console.ReadLine().ToLower() == "y")
                Directory.Delete(newDir, true);

        }
    }
}
