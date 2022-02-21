using System;
using Newtonsoft.Json;
using System.IO;

namespace lesson5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ToDo todolist1 = new ToDo("Сходить в магазин", false);
            todolist1.OrderNumber = 1;
            string jsonFile = JsonConvert.SerializeObject(todolist1);
            File.WriteAllText("todo.json", jsonFile);*/

            /*ToDo todolist2 = new ToDo("Сделать уроки", false);
            todolist2.OrderNumber = 2;
            string jsonFile = JsonConvert.SerializeObject(todolist2);
            File.WriteAllText("todo.json", jsonFile);*/

            string jsonText = File.ReadAllText("todo.json");
            ToDo todoList = JsonConvert.DeserializeObject<ToDo>(jsonText);
            todoList.TaskCompleted(0);
            string jsonResult = JsonConvert.SerializeObject(todoList);
            File.WriteAllText("todo_result.json", jsonResult);

        }
    }

    class ToDo
    {
        public string Title {get;set; }
        public int OrderNumber;
        public bool IsDone { get; set; }
        public ToDo (string title, bool isDone)
        {
            Title = title;
            IsDone = isDone;
        }

        public string TaskCompleted (int orderNumber)
        {
            Title = "[x]" + Title;
            IsDone = true;
            return $"[x] + {Title}";
        }

    }
}
