using System.Threading.Tasks;
using ToDoApp;

class Program
{
    static void Main(string[] args)
    {
        var tasks = new TaskCollection();

        while (true)
        {
            Console.Clear();
            tasks.Show();
            var cmd = WriteMenuAndGetCmd();
            if (cmd == "1") AddTask(tasks);
            else if (cmd == "2") MarkIsDone(tasks);
            else if (cmd == "3") Delete(tasks);
        }
    }

    private static void Delete(TaskCollection tasks)
    {
        Console.WriteLine("Hvilken oppgave vil du slette? (skriv inn nr til oppgaven)");
        var taskNoStr = Console.ReadLine();
        var taskNo = Convert.ToInt32(taskNoStr);
        if (taskNo < 1 || taskNo > tasks.GetCount()) Console.WriteLine("Skriv inn et gyldig tall");
        else tasks.DeleteTask(taskNo);
    }

    private static void MarkIsDone(TaskCollection tasks)
    {
        Console.WriteLine("Hvilken oppgave vil du markere fullført? (skriv inn nr til oppgaven)");
        var taskNoStr = Console.ReadLine();
        var taskNo = Convert.ToInt32(taskNoStr);
        if (taskNo < 1 || taskNo > tasks.GetCount()) Console.WriteLine("Skriv inn et gyldig tall");
        else tasks.MarkDone(taskNo);
    }

    private static void AddTask(TaskCollection myTasks)
    {
        Console.WriteLine("Skriv inn navn:");
        var name = Console.ReadLine();
        Console.WriteLine("Skriv inn når den skal være ferdig(dd/mm/yyyy):");
        DateTime dueDate;
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDateFromUser)) dueDate = dueDateFromUser;
        else
        {
            Console.WriteLine("Ugyldig datoformat. Bruker dagens dato.");
            dueDate = DateTime.Today;
        }
        myTasks.AddTask(name, dueDate);
    }    
    private static string? WriteMenuAndGetCmd()
    {
        Console.WriteLine("Hva vil du gjøre? ");
        Console.WriteLine("1 = Legg til ny");
        Console.WriteLine("2 = Marker fullført");
        Console.WriteLine("3 = Slett en oppgave");
        var cmd = Console.ReadLine();
        return cmd;
    }
}