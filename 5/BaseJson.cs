using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _5
{
    class BaseJson
    {
        private static string[] Tasks { get; set; }
        private static string NameBaseJson { get; } = "tasks.json";

        public static void CreateBaseJonson()
        {
            if (!File.Exists(NameBaseJson)) File.AppendAllText(NameBaseJson, "None");
        }
        public static void NewTask(string title)
        {
            int id;
            string[] array = BaseJson.ReadBase();
            if (array[0] != "None")
            {
                id = array.Length / 3 + 1;
                ToDo task = new ToDo(id, title);//как можно тут сделать рандомное имя обьекта? Например +1 каждый раз.
                Array.Resize(ref array, array.Length + 3);
            }
            else
            {
                id = 1;
                ToDo task = new ToDo(id, title);//как можно тут сделать рандомное имя обьекта? Например +1 каждый раз.
                Array.Resize(ref array, 3);
            }
            BaseJson.WriteBaseJson(array, id, title);
        }

        public static string[] ReadBase() => File.ReadAllLines(NameBaseJson);

        private static string[] ResizeBase(string[] array)
        {

            int count = 0;
            var newArray = array;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null) newArray[count++] = array[i];
            }
            count = 1;
            for (int i = 0; i < newArray.Length; i += 3)
            {
                newArray[i] = $"{count++}";
            }
            Array.Resize(ref newArray, newArray.Length - 3);           
            return newArray;
        }

        private static void SaveBaseJson(string[] array)
        {
            File.WriteAllLines(NameBaseJson, array);
            Table.CreateTable();
        }

        public static void WriteBaseJson(string[] array, int id, string title)
        {
            array[array.Length - 3] = id.ToString();
            array[array.Length - 2] = title;
            array[array.Length - 1] = "[ ]";
            File.WriteAllLines(NameBaseJson, array);
        }

        public static void ChangeDone(int id)
        {
            id = 3 * (id - 1);
            string[] array = ReadBase();
            for (int i = 0; i < array.Length;)
            {
                if (i == id)
                {
                    array[i + 2] = (array[i + 2] == "[ ]" ? "[ ]" : "[X]");
                    SaveBaseJson(array);
                    return;
                }
                i += 3;
            }
        }
        public static void DelTask(int id)
        {
            string[] array = ReadBase();
            if (array.Length <= 3) 
            { 
                DelAll(); 
                return; 
            }
              Array.Clear(array, 3 * (id -1), 3);
                    SaveBaseJson(ResizeBase(array));
        }
        public static void DelAll() => File.WriteAllText(NameBaseJson, "None");
        
    }
}


