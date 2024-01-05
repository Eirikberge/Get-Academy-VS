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

        public void MovePaddle()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                var moveLeft = key.Key == ConsoleKey.LeftArrow && PaddlePosition >= PaddleMoveDistance;
                var moveRight = key.Key == ConsoleKey.RightArrow && PaddlePosition < Console.WindowWidth - MyPaddle.Length;
                if (moveLeft || moveRight)
                {
                    var direction = moveLeft ? -1 : 1;
                    PaddlePosition += direction * 3 * MyPaddle.Length / 4;
                }
            }
        }
        public void UpdatePaddlePosition(int newPosition)
        {
            PaddlePosition = newPosition;
        }
    }
}
