namespace _341_B
{
    internal class IncreasePoints : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = ' ';

        public IncreasePoints(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.IncreasePoints();
        }
    }
}
