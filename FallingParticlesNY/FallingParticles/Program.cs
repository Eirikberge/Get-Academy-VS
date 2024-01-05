namespace FallingParticles
{
    internal class Program
    {
        static void Main()
        {
            var paddle = new Paddle();
            var particle = new Particle();
            var game = new Game(paddle);


            Console.CursorVisible = false;
            Console.WindowWidth = 80;
            while (true)
            {
                game.RunGame(particle, paddle, game);
                EndGame();
            }
        }

        private static void EndGame()
        {
            var text = "Game Over! Press ENTER to restart";
            Console.SetCursorPosition(40 - text.Length / 2, 5);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }

}
