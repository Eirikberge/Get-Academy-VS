namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomNr = random.Next(1,100);
            while (true)
            {
                Console.WriteLine("Gjett et tall mellom 1-100");
                var input = Console.ReadLine();
                var intputNr = Convert.ToInt32(input);
                Console.WriteLine(randomNr);
                if (intputNr > randomNr)
                {
                    Console.WriteLine("Du gjettet for høyt!");
                }
                else if (intputNr < randomNr)
                {
                    Console.WriteLine("Du gjettet for lavt!");
                }
                else if (randomNr == intputNr)
                {
                    Console.WriteLine("Riktig");
                }
            }
        }
    }
}
