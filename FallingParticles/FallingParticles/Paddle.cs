
namespace FallingParticles
{
    internal class Paddle
    {
        public int PaddlePosition { get; private set; }
        public int PaddleMoveDistance { get; }
        public string MyPaddle { get; }

        public Paddle(int paddlePosition = 0, int paddleMoveDistance = 6, string paddle = "========")
        {
            PaddlePosition = paddlePosition;
            PaddleMoveDistance = paddleMoveDistance;
            MyPaddle = paddle;
        }
        public void UpdatePaddlePosition(int newPosition)
        {
            PaddlePosition = newPosition;
        }

    }
}
