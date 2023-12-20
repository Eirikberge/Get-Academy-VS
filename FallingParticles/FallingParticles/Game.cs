using System.Reflection.Emit;

namespace FallingParticles
{
    internal class Game
    {
        private Paddle paddle;
        private List<Particle> particles = new List<Particle>(); // Brukes i SpawnParticle
        private bool _isGameOver; // Brukes egentlig ikke, men er også i InitializeGame
        public int Level { get; private set; } // Brukes i Main, InitializeGame, og DrawGame
        public int Score { get; private set; } // Brukes i InitializeGame, DrawGame og MoveParticles
        public int GameRoundsBetweenSpawn { get; set; } // Brukes i Main, InitGameRoundsBetweenSpawn
        private static readonly Random random = new Random(); //Denne skal til Particles, siden den kun brukes i SpawnParticle

        public Game(bool isGameOver, int level, int score, int gameRoundsBetweenSpawn, Paddle paddle)
        {
            _isGameOver = isGameOver;
            Level = level;
            Score = score;
            GameRoundsBetweenSpawn = gameRoundsBetweenSpawn;
            this.paddle = paddle;
        }

        public void InitializeGame()
        {
            var centerX = Console.WindowWidth / 2;
            paddle.PaddlePosition = centerX - (centerX % paddle.PaddleMoveDistance);
            particles.Clear();
            _isGameOver = false;
            Score = 0;
            Level = 1;
            InitGameRoundsBetweenSpawn();
        }

        public void InitGameRoundsBetweenSpawn()
        {
            GameRoundsBetweenSpawn = 50 / Level;
        }

        public void MoveParticles()
        {
            for (var index = particles.Count - 1; index >= 0; index--)
            {
                var particle = particles[index];
                particle.Y += 0.5f;
                if (particle.Y > Console.WindowHeight - 1)
                {
                    Score++;
                    particles.Remove(particle);
                }
            }
        }

        public bool CheckLostParticle()
        {

            foreach (var particle in particles)
            {
                if ((particle.X < paddle.PaddlePosition || particle.X > paddle.PaddlePosition + paddle.myPaddle.Length)
                    && particle.Y == Console.WindowHeight - 1)
                {
                    return true;
                }
            }

            return false;
        }
        public void SpawnParticles()
        {
            var newParticle = new Particle
            {
                X = random.Next(0, Console.WindowWidth),
                Y = 0
            };
            particles.Add(newParticle);
        }

        public void AddLevel()
        {
            Level++;
        }

        public void DrawPartical()
        {
            foreach (var particle in particles)
            {
                var particleX = (int)Math.Floor(particle.X);
                var particleY = (int)Math.Floor(particle.Y);
                Console.SetCursorPosition(particleX, particleY);
                Console.Write("O");
            }
        }
    }


}
