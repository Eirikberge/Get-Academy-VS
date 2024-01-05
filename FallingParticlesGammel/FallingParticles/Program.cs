namespace FallingParticles
{
    internal class Program
    {
        static void Main()
        {
            var paddle = new Paddle();
            var game = new Game(paddle);

            Console.CursorVisible = false;
            Console.WindowWidth = 80;
            while (true)
            {
                InitializeGame(game);
                var levelCount = 0;
                var roundCount = 45;
                while (true)
                {
                    DrawGame(game, paddle);
                    MovePaddle(paddle);
                    MoveParticles(game);
                    var hasLostParticle = CheckLostParticle(game);
                    if (hasLostParticle) break;
                    if (roundCount >= game.GameRoundsBetweenSpawn)
                    {
                        SpawnParticles(game);
                        InitGameRoundsBetweenSpawn(game);
                        roundCount = 0;
                    }
                    roundCount++;
                    levelCount++;
                    if (levelCount == 100)
                    {
                        levelCount = 0;
                        game.IncreaseLevel();
                    }
                    Thread.Sleep(100);
                }
                var text = "Game Over! Press ENTER to restart";
                Console.SetCursorPosition(40 - text.Length / 2, 5);
                Console.WriteLine(text);
                Console.ReadLine();
            }
        }

        static void InitializeGame(Game game)
        {
            game.InitializeGame();
        }

        static void InitGameRoundsBetweenSpawn(Game game)
        {
            game.InitGameRoundsBetweenSpawn();
        }

        static void DrawGame(Game game, Paddle paddle)
        {
            Console.Clear();
            Console.SetCursorPosition(60, 0);
            Console.Write($"Score: {game.Score}");
            Console.SetCursorPosition(71, 0);
            Console.Write($"Level: {game.Level}");
            Console.SetCursorPosition(paddle.PaddlePosition, Console.WindowHeight - 1);
            Console.Write(paddle.MyPaddle);

            game.GetPartical();
        }
        static void MovePaddle(Paddle paddle)
        {
            paddle.MovePaddle();
        }
        static void MoveParticles(Game game)
        {
            game.MoveParticles();
        }

        static bool CheckLostParticle(Game game)
        {
            return game.CheckLostParticle();
        }
        static void SpawnParticles(Game game)
        {
            game.SpawnParticles();
        }
    }
}
