using System.Threading.Tasks;
using ToDoApp;

class Program
{
    static void Main(string[] args)
    {
        var myTasks = modelData();

        while (true)
        {
            Console.Clear();
            Show(myTasks);
            var cmd = GetCmd();
            if (cmd == "1")
            {
                FirstCmdText(myTasks);
            }
            else if (cmd == "2")
            {
                SecondCmdText(myTasks);
            }

        }
    }

    private static string? GetCmd()
    {
        Console.WriteLine("Hva vil du gjøre? ");
        Console.WriteLine("1 = Legg til ny");
        Console.WriteLine("2 = Marker fullført");
        var cmd = Console.ReadLine();
        return cmd;
    }

    private static void SecondCmdText(List<ToDoApp.Task> myTasks)
    {
        Console.WriteLine("Hvilken oppgave vil du markere fullført? (skriv inn nr til oppgaven)");
        var input = Console.ReadLine();
        var inputToInt = Convert.ToInt32(input);
        if (inputToInt < 1 || inputToInt > myTasks.Count)
        {
            Console.WriteLine("Skriv inn et gyldig tall");
        }
        else
        {
            myTasks[inputToInt - 1].isDone = true;
        }
    }

    private static void FirstCmdText(List<ToDoApp.Task> myTasks)
    {
        var newTask = new ToDoApp.Task();
        Console.WriteLine("skriv inn navn:");
        newTask.Name = Console.ReadLine();
        Console.WriteLine("Skriv inn når skal den være ferdig(dd/mm/yyyy):");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
        {
            newTask.DueDate = dueDate;
            newTask.isDone = false;
            myTasks.Add(newTask);
        }
        else
        {
            Console.WriteLine("Ugyldig datoformat. Bruker dagens dato.");
            newTask.DueDate = DateTime.Today;
            newTask.isDone = false;
            myTasks.Add(newTask);
        }

        // Denne ifen med dato må jeg høre om, er fra chatGPT
        // begge ifer som tar imot tall som int
    }

    static List<ToDoApp.Task> modelData()
    {
        var myTasks = new List<ToDoApp.Task>
        {
            new ToDoApp.Task()
            {
                Name = "Vaske",
                DueDate = new DateTime(2023, 11, 22),
                isDone = true,
            },
            new ToDoApp.Task()
            {
                Name = "Rydde",
                DueDate = new DateTime(2023, 12, 22),
                isDone = false,
            },
            new ToDoApp.Task()
            {
                Name = "Støvsuge",
                DueDate = new DateTime(2023, 11, 22),
                isDone = true,
            },
        };
        return myTasks;
    }

    static void Show(List<ToDoApp.Task> myTasks)
    {
        Console.WriteLine("Oppgave:  Frist:    Fullført:");
        Console.WriteLine();
        foreach (var task in myTasks)
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
    private static void CreateTaskText(ToDoApp.Task task)
    {
        Console.Write(task.Name.PadRight(10));
        Console.Write(task.DueDate.ToString("dd/MM/yy"));
        Console.WriteLine(task.isDone ? $"    Ja" : "   Nei");
    }
}



//var myTasks = new Tasks[] {myTask1, myTask2, myTask3};
//var myTask = new Tasks[3];
//myTask[0] = myTask1;


//var tasks = new List<Task>();
//tasks.Add(task1);