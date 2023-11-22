namespace PasswordGenerator
{
    internal class Program
    {
        static bool IsValid()
        {

        }
        static void ShowPW()
        {

        }
        static void MakePW(string s)
        {
            foreach (var c in s)
            {
                if (char.IsDigit(c))
                {
                    ShowPW();
                }
            }
            ShowHelpText(); ()
        }
        static void ShowHelpText()
        {
            Console.WriteLine(@"PasswordGenerator  
Options:
- l = liten bokstav
- L = stor bokstav
- d = siffer
- s = spesialtegn (!""#¤%&/(){}[]
Eksempel: PasswordGenerator 14 lLssdd
    betyr
        Min. 1 liten bokstav
        Min. 1 1 stor bokstav
        Min. 2 spesialtegn
        Min. 2 sifre
        Lengde på passordet skal være 14");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            string arg = Console.ReadLine();
            string s = "(!"#¤%&/(){}[]";
            Console.WriteLine("Lag Passord");

        }
    }
}
