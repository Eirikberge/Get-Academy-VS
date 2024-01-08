namespace _329A_NY
{
    internal class Player
    {
        private string _name;
        private int _points;

        public Player(string name, int points)
        {
            _name = name;
            _points = points;
        }


        public void Play(Player player2)
        {

            //var random = new Random();
            //var winner = random.Next(2) == 0 ? this : player2;
            //var loser = winner == this ? player2 : this;
            //winner._points += 1;
            //loser._points -= 1;

            var random = new Random();
            int number = random.Next(2);
            if (number % 2 == 0)
            {
                player2._points++;
                _points--;
            }
            else
            {
                _points++;
                player2._points--;
            }
        }
        public void ShowNameAndPoints()
        {
            Console.WriteLine(_name.PadRight(10) + _points.ToString().PadLeft(3));
        }
    }
}
