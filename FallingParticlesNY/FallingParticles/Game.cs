using System;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace FallingParticles
{
    internal class Game
    {
        private Paddle _paddle;
        private bool _isGameOver;
        private int Level; 
        private int Score; 
        private int GameRoundsBetweenSpawn; 
        private Random _random = new Random();


        public Game(Paddle paddle)
        {
            _isGameOver = false;
            Level = 0;
            Score = 0;
            GameRoundsBetweenSpawn = 0;
            _paddle = paddle;
        }

        public void RunGame(Particle particle, Paddle paddle, Game game)
        {
            InitializeGame(particle);
            var levelCount = 0;
            var roundCount = 45;
            while (true)
            {
                DrawGame();
                particle.GetPartical();
                MovePaddle();
                particle.MoveParticles(game);
                var hasLostParticle = particle.CheckLostParticle(paddle); // Hva med denne?
                if (hasLostParticle) break;
                if (roundCount >= GameRoundsBetweenSpawn)
                {
                    SpawnParticles(particle);
                    InitGameRoundsBetweenSpawn();
                    roundCount = 0;
                }
                roundCount++;
                levelCount++;
                if (levelCount == 100)
                {
                    levelCount = 0;
                    Level++;
                }
                Thread.Sleep(100);
            }
        }
        public void InitializeGame(Particle particle)
        {
            var centerX = Console.WindowWidth / 2;
            _paddle.UpdatePaddlePosition(centerX - (centerX % _paddle.PaddleMoveDistance));
            particle.ClearParticles();
            _isGameOver = false;
            Score = 0;
            Level = 1;
            InitGameRoundsBetweenSpawn();
        }

        public void DrawGame()
        {
            Console.Clear();
            Console.SetCursorPosition(60, 0);
            Console.Write($"Score: {Score}");
            Console.SetCursorPosition(71, 0);
            Console.Write($"Level: {Level}");
            Console.SetCursorPosition(_paddle.PaddlePosition, Console.WindowHeight - 1);
            Console.Write(_paddle.MyPaddle);
        }

        public void InitGameRoundsBetweenSpawn()
        {
            GameRoundsBetweenSpawn = 50 / Level;
        }

        public void SpawnParticles(Particle particle)
        {
            var newParticle = new Particle
            {
                X = _random.Next(0, Console.WindowWidth),
                Y = 0
            };
            particle.AddParticle(newParticle);
        }
        public void IncreaseScore()
        {
            Score++;
        }

        private void MovePaddle()
        {
            _paddle.MovePaddle();
        }
    }
}
