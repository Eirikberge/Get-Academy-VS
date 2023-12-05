using _323_B__football_betting_v2_;

namespace _323_B__football_betting_v2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \n" +
                          " - H, U, B\n" +
                          " - halvgardering: HU, HB, UB\n" +
                          " - helgardering: HUB\n" +
                          "Skriv inn dine 12 tippinger med komma mellom hver (en tipping for hver kamp): ? ");
            var betsText = Console.ReadLine();
            var matches = new TwelveMatches(betsText);
            while (true)
            {
                Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
                var command = Console.ReadLine();
                if (command == "X") break;
                var matchNo = Convert.ToInt32(command);
                Console.Write("Kommandoer: \n" +
                              " - H = scoring hjemmelag\n" +
                              " - B = scoring bortelag\n" +
                              " - X = kampen er ferdig\n" +
                              "Angi kommando: ");
                var team = Console.ReadLine();
                matches.AddGoal(matchNo, team == "H");
                matches.ShowAllScores();
                matches.ShowCorrectCount();

            }
        }
    }
}