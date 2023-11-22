namespace Testin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Det er {args.Length} parametre.");
            if (args.Length == 0) return;
            for (var i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Parameter {i + 1} har verdien {args[i]}");
            }
            return;
        }
    }
}