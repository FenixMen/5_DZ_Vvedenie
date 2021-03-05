using System;
using System.IO;

namespace _3
{
    class Program
    {//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор чисел (0...255) через пробел");

            string[] inValueArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            try
            {
                byte[] array = new byte[inValueArray.Length];
                for (int i = 0; i < inValueArray.Length; i++)
                {
                    array[i] = byte.Parse(inValueArray[i]);
                }
                File.WriteAllBytes("binFile", array);
                Console.WriteLine("набор чисел сохранен в файле 'binFile'\n" +
                                  "удалить фал 'binFile'? \n'Y' - да");
                if (Console.ReadLine().ToLower() == "y")
                {
                    File.Delete("binFile");
                    Console.WriteLine("Файл удален!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введены некоректные данные");
            }


        }
    }
}
