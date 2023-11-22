using System;

namespace Testing_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 101);
            int tries = 0;
            int guessedNumber;

            do
            {
                Console.WriteLine("Gjett tallet mellom 1 og 100:");
                guessedNumber = Convert.ToInt32(Console.ReadLine());
                tries++;

                if (number > guessedNumber)
                {
                    Console.WriteLine("Du gjettet feil, tallet er for lavt");
                }
                else if (guessedNumber > number)
                {
                    Console.WriteLine("Du gjettet feil, tallet er for høyt");
                }
            } while (guessedNumber != number);

            Console.WriteLine($"Gratulerer, du gjettet riktig på {tries} forsøk!");
        }
    }
}
// Lag et program som trekker tilfeldig "hemmelig tall". La brukeren gjette og gi tilbaemelding om det er riktig eller feil + ev om det er for høyt eller for lavt. 
// Tell hvor mange forsøk han bruker på å gjette riktig.