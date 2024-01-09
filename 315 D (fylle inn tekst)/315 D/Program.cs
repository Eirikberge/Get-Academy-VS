namespace _315_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn en tekst");
            var insertedText = Console.ReadLine();
            string[] listedText = insertedText.Split(' ');
            var longestWord = "";

            Console.WriteLine($"Det er {listedText.Length} ord i teksten din");
            foreach (var word in listedText)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine($"{longestWord} er det lengste ordet i teksten");
        }
    }
}