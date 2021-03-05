using System;
using System.IO;

namespace _2
{
    class Program
    {// Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            File.AppendAllText("startup.txt", $"{date.ToString("T")}\n");
            Console.WriteLine($"В файл 'startup.txt' записано значение {date.ToString("T")}");

            Console.WriteLine("удалить фал? \n'Y' - да, 'N' - нет.");
            if (Console.ReadLine().ToLower() == "y")
            {
                File.Delete("startup.txt");
                Console.WriteLine("Файл удален!");
            }
        }
    }
}
