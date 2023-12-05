namespace Colors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var color = new Color();

            while (true)
            {
                var cmd = GetMenuAndCmd(color);
                if (cmd == "1") LightningColor(color);
                else if (cmd == "2") DarkeningColor(color);
                else if (cmd == "3") InvertColor(color);
                else if (cmd == "4") NextColor(color);
                else if (cmd == "5") PreviousColor(color);
            }
        }

        private static string? GetMenuAndCmd(Color color)
        {
            color.SetColor();
            var consoleColor = color.GetConsoleColor();
            Console.Clear();
            Console.WriteLine("Farge: " + consoleColor);
            Console.WriteLine("Hva vil du gjøre? ");
            Console.WriteLine(" 1 = gå fra mørk til lys");
            Console.WriteLine(" 2 = gå fra lys til mørk");
            Console.WriteLine(" 3 = inverter ");
            Console.WriteLine(" 4 = neste ");
            Console.WriteLine(" 5 = forrige ");

            return Console.ReadLine();
        }

        private static void PreviousColor(Color color)
        {
             color.PreviousColor();
        }

        private static void NextColor(Color color)
        {
            color.NextColor();
        }

        private static void InvertColor(Color color)
        {
            color.InvertColor();
        }

        private static void DarkeningColor(Color color)
        {
            color.DarkeningColor();
        }

        private static void LightningColor(Color color)
        {
            color.LightningColor();
        }
    }
}
/*
   Black = 0,
   DarkBlue = 1,
   DarkGreen = 2,
   DarkCyan = 3,
   DarkRed = 4,
   DarkMagenta = 5,
   DarkYellow = 6,
   Gray = 7,
   DarkGray = 8,
   Blue = 9,
   Green = 10,
   Cyan = 11,
   Red = 12,
   Magenta = 13,
   Yellow = 14,
   White = 15
 */