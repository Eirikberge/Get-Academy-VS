namespace Stable
{
    internal class Stable
    {
        private List<Horse> _stableHorses;
        private Horse _horse;
        private Race _race;

        public Stable()
        {
            _stableHorses = new List<Horse>();
        }

        public void AddHorseToStable(Horse horse)
        {
            _stableHorses.Add(horse);
        }

        public void FeedHorse(Horse horse)
        {
            horse.IsFed = true;
        }

        public void AddToRacing(Horse horse)
        {
            _race.AddToRacing(horse);
        }
    }
}
