using System.Reflection.Emit;

namespace FallingParticles
{
    internal class Game
    {
        private Paddle _paddle;
        private List<Particle> _particles = new List<Particle>(); // Brukes i SpawnParticle
        private bool _isGameOver; // Finnes i InitializeGame
        public int Level { get; private set; } // Brukes i InitializeGame, og DrawGame
        public int Score { get; private set; } // Brukes i InitializeGame, DrawGame og MoveParticles
        public int GameRoundsBetweenSpawn { get; private set; } // Brukes i Main, InitGameRoundsBetweenSpawn
        private Random _random = new Random();

        public Game(Paddle paddle)
        {
            _isGameOver = false;
            Level = 0;
            Score = 0;
            GameRoundsBetweenSpawn = 0;
            _paddle = paddle;
        }

        public void InitializeGame()
        {
            var centerX = Console.WindowWidth / 2;
            _paddle.UpdatePaddlePosition(centerX - (centerX % _paddle.PaddleMoveDistance));
            _particles.Clear();
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
            for (var index = _particles.Count - 1; index >= 0; index--)
            {
                var particle = _particles[index];
                particle.Y += 0.5f;
                if (particle.Y > Console.WindowHeight - 1)
                {
                    Score++;
                    _particles.Remove(particle);
                }
            }
        }

        public bool CheckLostParticle()
        {
            foreach (var particle in _particles)
            {
                if ((particle.X < _paddle.PaddlePosition || particle.X > _paddle.PaddlePosition + _paddle.MyPaddle.Length)
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
                X = _random.Next(0, Console.WindowWidth),
                Y = 0
            };
            _particles.Add(newParticle);
        }

        public void GetPartical()
        {
            foreach (var particle in _particles)
            {
                var particleX = (int)Math.Floor(particle.X);
                var particleY = (int)Math.Floor(particle.Y);
                Console.SetCursorPosition(particleX, particleY);
                Console.Write("O");
            }
        }

        public void IncreaseLevel()
        {
            Level++;
        }
    }
}
