namespace Testin3
{
    internal class Program
    {
        static void Main()
        {
            var points = 0;
            var letter = 'A';

            while (true)
            {
                Console.WriteLine($"{letter}={points}");
                var inputStr = Console.ReadLine();
                var inputLetter = inputStr[0];
                if (inputLetter == letter)
                {
                    points++;
                }
            }
        }
    }
}