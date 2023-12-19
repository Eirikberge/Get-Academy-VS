namespace _331_B
{
    internal class ClickerGame
    {
        private int _points;
        private int _pointsPerClick;
        private int _pointsPerClickIncrease;

        public ClickerGame(int points = 0, int pointsPerClick = 1, int pointsPerClickIncrease = 1)
        {
            _points = points;
            _pointsPerClick = pointsPerClick;
            _pointsPerClickIncrease = pointsPerClickIncrease;
        }


        public void Click()
        {
            _points += _pointsPerClick;

        }

        public int GetPoints()
        {
            return _points;
        }

        public void BuyUpgrade()
        {
            _points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;
        }

        public void BuySuperUpgrade()
        {
            _points -= 100;
            _pointsPerClickIncrease++;
        }
    }
}
