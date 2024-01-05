using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System;

namespace FallingParticles
{
    internal class Particle
    {
        public float X { get; set; }
        public float Y { get; set; }
        private List<Particle> _particles = new List<Particle>(); // Brukes i SpawnParticle
        


        public void MoveParticles(Game game)
        {
            for (var index = _particles.Count - 1; index >= 0; index--)
            {
                var particle = _particles[index];
                particle.Y += 0.5f;
                if (particle.Y > Console.WindowHeight - 1)
                {
                    game.IncreaseScore();
                    _particles.Remove(particle);
                }
            }
        }

        public bool CheckLostParticle(Paddle paddle)
        {
            foreach (var particle in _particles)
            {
                if ((particle.X < paddle.PaddlePosition || particle.X > paddle.PaddlePosition + paddle.MyPaddle.Length)
                    && particle.Y == Console.WindowHeight - 1)
                {
                    return true;
                }
            }
            return false;
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

        public void ClearParticles()
        {
            _particles.Clear();
        }

        public void AddParticle(Particle newParticle)
        {
            _particles.Add(newParticle);
        }
    }
}
