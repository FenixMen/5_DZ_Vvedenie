using System;
using System.IO;

namespace _1
{
    class Program
    {//Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите что нибудь");
            string inValue = Console.ReadLine();

            File.WriteAllText("inFromConsole.txt", inValue);
            Console.WriteLine($"ваш текст '{inValue}' сохранен в файле 'inFromConsole.txt'");
        }
    }
}
