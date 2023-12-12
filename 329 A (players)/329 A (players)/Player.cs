namespace _329_A__players_
{
    internal class Player
    {
        private readonly string _name;
        private int _points;

        public Player(string name, int points)
        {
            _name = name;
            _points = points;
        }
        public void Play(Player player2)
        {
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
            Console.WriteLine($"Name: {_name} Poeng: {_points}");
        }
    }
}
