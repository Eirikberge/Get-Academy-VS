namespace _323_B__football_betting_v2_
{
    internal class Match
    {
        private int _homeGoals;
        private int _awayGoals;
        private readonly string _bet;
        public bool isRunning { get; private set; }

        public Match(string bet)
        {
            _bet = bet;
            isRunning = true;
        }

        public void Stop()
        {
            isRunning = false;
        }

        public void AddGoal(bool isHomeTeam)
        {
            if (isHomeTeam) _homeGoals++;
            else _awayGoals++;
        }

        public string GetScore()
        {
            return _homeGoals + "-" + _awayGoals;
        }

        public bool IsBetCorrect()
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            return _bet.Contains(result);
        }
    }


}