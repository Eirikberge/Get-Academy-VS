namespace HarryPotter
{
    internal class SpellEffects
    {
        public SpellEffects() { }

        public void ShowFireworks()
        {
            Console.CursorVisible = false;

            for (int i = 0; i < 50; i++)
            {
                Console.Clear();
                DrawFirework(i % 2 == 0 ? ConsoleColor.Cyan : ConsoleColor.Yellow);
                Thread.Sleep(100);
            }

            Console.ResetColor();
            Console.Clear();
            Console.CursorVisible = true;
        }

        public void DrawFirework(ConsoleColor color)
        {
            Console.ForegroundColor = color;

            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;

            Console.SetCursorPosition(centerX, centerY);
            Console.Write("*");

            Random random = new Random();

            for (int i = 0; i < 30; i++)
            {
                double angle = random.NextDouble() * 2 * Math.PI;
                int radius = random.Next(5, 15);
                int x = (int)(centerX + radius * Math.Cos(angle));
                int y = (int)(centerY + radius * Math.Sin(angle));

                Console.SetCursorPosition(x, y);
                Console.Write("*");
            }
        }
    }
}
