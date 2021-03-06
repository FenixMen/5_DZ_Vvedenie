using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _5
{
    
    // написать приложение для ввода списка задач;
    // задачу описать классом ToDo с полями Title и IsDone;
    //на старте, если есть файл tasks.json/xml/bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
    //если задача выполнена, вывести перед её названием строку «[x]»;
    //вывести порядковый номер для каждой задачи;
    //при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
    //записать актуальный массив задач в файл tasks.json/xml/bin.
    public class FileTask{}
    public class ToDo
    {
        private int Id { get; set; }
        private string Title { get; set; }
        private string IsDone { get; set; }

        public ToDo(int id, string title){}

        public static void TableAct()
        {
            Console.WriteLine("\n\n[Change] - Изменить статус цели 1");
            Console.WriteLine("[Del], удаленить цель 1");
            Console.WriteLine("[DelAll] - Очистить список");
            Console.WriteLine("[New] - новая задача");
            Console.WriteLine("[Exit] -выход");
            string userVoid = (Console.ReadLine().ToLower());
            if (userVoid == "change")
            {
                Console.WriteLine("Укажите номер цели");
                if (int.TryParse(Console.ReadLine(), out int id))
                BaseJson.ChangeDone(id);
                else
                    Console.WriteLine("Ошибка ввода");
            }
                if (userVoid == "del")
                {
                Console.WriteLine("Укажите номер цели");
                
                if (int.TryParse(Console.ReadLine(), out int id))
                    BaseJson.DelTask(id);
                else
                    Console.WriteLine("Ошибка ввода");
            }
                    if (userVoid == "delall")
                    {
                        Console.WriteLine("Это удалит все задачи, вы уверены? Y - да, N - отмена");
                            if (Console.ReadLine().ToLower() == "y")
                                BaseJson.DelAll();
                    }
                        if (userVoid == "new")
                        {
                            Console.WriteLine("Введите название цели");
                            BaseJson.NewTask(Console.ReadLine());
                            Table.CreateTable();
                        }
                            if (userVoid == "exit") return;
        }
    }
}


