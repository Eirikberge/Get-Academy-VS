using System.Reflection.Emit;

namespace Watch
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WindowWidth = 185;

            while (true)
            {
                Timer(60, DateTime.Now.Second, "Sekunder");
                Timer(60, DateTime.Now.Minute, "Minutter");
                Timer(24, DateTime.Now.Hour, "Timer");

                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        private static void Timer(int timeUnits, int TimeTeller, string Label)
        {

            Ticker(TimeTeller, Label);
            ShowNr(timeUnits);

        }

        private static void ShowNr(int timeUnits)
        {
            for (int unit = 1; unit <= timeUnits; unit++)
            {
                Console.Write(unit.ToString().PadLeft(3, ' '));
            }
            Console.WriteLine(' ');
        }

        private static void Ticker(int TimeTeller, string Label)
        {
            Console.WriteLine(Label + ':');
            Console.WriteLine("*".PadLeft(3 * TimeTeller, ' '));
        }
    }
}