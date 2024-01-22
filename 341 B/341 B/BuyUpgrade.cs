namespace _341_B
{
    internal class BuyUpgrade : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = 'K';


        public BuyUpgrade(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.BuyUpgrade();
        }
    }
}
