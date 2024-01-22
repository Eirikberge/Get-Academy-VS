namespace _341_B
{
    internal class ClickerGame
    {
        public int Points { get; private set; } = 0;
        int _pointsPerClick = 1;
        int _pointsPerClickIncrease = 1;



        public void IncreasePoints()
        {
            Points += _pointsPerClick;
        }

        public void BuyUpgrade()
        {
            if (Points < 10) return;
            Points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;
        }

        public void BuySuperUpgrade()
        {
            if(Points < 100) return;
            Points -= 100;
            _pointsPerClickIncrease++;
        }
    }
}
