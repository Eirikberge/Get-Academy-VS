﻿namespace ToDoApp
{
    internal class TaskCollection
    {
        private List<Task> _tasks = CreateTasks();

        public void Show()
        {
            Console.WriteLine("Oppgave:  Frist:    Fullført:");
            Console.WriteLine();
            foreach (var task in _tasks)
            {
                if (task.isDone)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    CreateTaskText(task);
                    Console.ResetColor();
                }
                else
                {
                    CreateTaskText(task);
                }
            }
            Console.WriteLine();
        }

        public int GetCount()
        {
            return _tasks.Count;
        }

        private void CreateTaskText(ToDoApp.Task task)
        {
            Console.Write(task.Name.PadRight(10));
            Console.Write(task.DueDate.ToString("dd/MM/yy"));
            Console.WriteLine(task.isDone ? $"    Ja" : "   Nei");
        }

        private static List<Task> CreateTasks()
        {
            return new List<Task>
            {
                new Task()
                {
                    Name = "Vaske",
                    DueDate = new DateTime(2023, 11, 22),
                    isDone = true,
                },
                new Task()
                {
                    Name = "Rydde",
                    DueDate = new DateTime(2023, 12, 22),
                    isDone = false,
                },
                new Task()
                {
                    Name = "Støvsuge",
                    DueDate = new DateTime(2023, 11, 22),
                    isDone = true,
                },
            };
        }

        public void MarkDone(int taskNo)
        {
            _tasks[taskNo - 1].MarkDone();
        }
        //private static void MarkDone(List<ToDoApp.Task> myTasks)
        //{
        //    Console.WriteLine("Hvilken oppgave vil du markere fullført? (skriv inn nr til oppgaven)");
        //    var input = Console.ReadLine();
        //    var inputToInt = Convert.ToInt32(input);
        //    if (inputToInt < 1 || inputToInt > myTasks.Count) Console.WriteLine("Skriv inn et gyldig tall");
        //    else myTasks[inputToInt - 1].isDone = true;
        //}
        public void AddTask(string name, DateTime dueDate)
        {
            var task = new Task();
            task.Name = name;
            task.DueDate = dueDate;
            task.isDone = false;
            _tasks.Add(task);
        }

        public void DeleteTask(int taskNo)
        {
            _tasks.RemoveAt(taskNo - 1);
        }
    }
}
