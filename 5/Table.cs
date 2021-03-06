using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    class Table
    {
        public static void CreateTable()
        {
            Console.Clear();
            BaseJson.CreateBaseJonson();
            int column = 0;
            Console.WriteLine("№\tЦель\t\t\tСтатус");//Существует ли привязка строк по столбцам?  ну типа по самому длинному тексту в Цели равняются все Статусы?
            string[] array = BaseJson.ReadBase();
            if (array[0] != "None")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != "")
                    {
                        if (column < 3)
                            Console.Write($"{array[i]}\t");
                        else
                        {
                            Console.Write($"\n{array[i]}\t");
                            column = 0;
                        }
                        column++;
                    }
                }
            }
            ToDo.TableAct();
        }
    }
}
