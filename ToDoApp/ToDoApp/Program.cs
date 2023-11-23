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
            Console.WriteLine("Hva vil du gjøre? ");
            Console.WriteLine("1 = Legg til ny");
            Console.WriteLine("2 = Marker fullført");
            var cmd = Console.ReadLine();
            var ask = "Skriv inn";
            if (cmd == "1")
            {
                var newTask = new Tasks();
                Console.WriteLine($"{ask} navn:");
                newTask.Name = Console.ReadLine();
                Console.WriteLine($"{ask} når skal den være ferdig(dd/mm/yyyy):");
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
            else if (cmd == "2")
            {
                Console.WriteLine("Hvilken oppgave vil du markere fullført? (skriv inn nr til oppgaven)");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int DoTaskDone))
                {
                    Console.WriteLine($"Du valgte oppgave nummer {DoTaskDone}");
                    myTasks[DoTaskDone - 1].isDone = true;

                }
                else
                {
                    Console.WriteLine("Ugyldig inntasting. Skriv inn et gyldig nummer.");
                }
            }

        }
    }

    static List<Tasks> modelData()
    {
        var myTasks = new List<Tasks>
        {
            new Tasks()
            {
                Name = "Vaske",
                DueDate = new DateTime(2023, 11, 22),
                isDone = true,
            },
            new Tasks()
            {
                Name = "Rydde",
                DueDate = new DateTime(2023, 12, 22),
                isDone = false,
            },
            new Tasks()
            {
                Name = "Støvsuge",
                DueDate = new DateTime(2023, 11, 22),
                isDone = true,
            },
        };
        return myTasks;
    }

    static void Show(List<Tasks> myTasks)
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
    private static void CreateTaskText(Tasks task)
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