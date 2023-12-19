namespace _331_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clickerGame = new ClickerGame();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n"
                                  + " - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       "
                                  + "koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       "
                                  + "øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       "
                                  + "koster 100 poeng\r\n - X = avslutt applikasjonen");
                Console.WriteLine($"Du har {GetPoints(clickerGame)} poeng.");   
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var command = Console.ReadKey().KeyChar;
                if (command is 'X' or 'x') Environment.Exit(0);
                else if (command is ' ') Click(clickerGame);
                else if (command is 'K' or 'k' && GetPoints(clickerGame) >= 10) BuyUpgrade(clickerGame);
                else if (command is 'S' or 's' && GetPoints(clickerGame) >= 100) BuySuperUpgrade(clickerGame);
            }
        }

        private static void BuySuperUpgrade(ClickerGame clickerGame)
        {
            clickerGame.BuySuperUpgrade();
        }

        private static void BuyUpgrade(ClickerGame clickerGame)
        {
            clickerGame.BuyUpgrade();
        }
        private static int GetPoints(ClickerGame clickerGame)
        {
            return clickerGame.GetPoints();
        }

        private static void Click(ClickerGame clickerGame)
        {
            clickerGame.Click();
        }
    }
}