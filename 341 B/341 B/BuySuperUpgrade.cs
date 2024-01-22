namespace _341_B
{
    internal class BuySuperUpgrade : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = 'S';

        public BuySuperUpgrade(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.BuySuperUpgrade();
        }
    }
}
