namespace NewStable
{
    internal class Race
    {
        private List<Horse> _racingHorses;
        private int RaceDistance;

        public Race()
        {
            _racingHorses = new List<Horse>();
            RaceDistance = 300;
        }

        public void AddToRacing(Horse horse)
        {
            _racingHorses.Add(horse);
        }

        public void DoRacing()
        {
            var random = new Random();
            foreach (var horse in _racingHorses)
            {
                var randomSpeed = random.Next(20,35);
                horse.DistanceRan += randomSpeed;
                Console.WriteLine($"{horse.Name} har løpt {randomSpeed}");
            }
        }

        public bool IsRaceDone()
        {
            foreach (var horse in _racingHorses)
            {
                if (horse.DistanceRan >= RaceDistance) return true;
            }
            return false;
        } 
        public void PrintWinner()
        {
            foreach (var horse in _racingHorses)
            {
                if (horse.DistanceRan >= RaceDistance)
                {
                    Console.WriteLine($"{horse.Name} er vinner med {horse.DistanceRan}");
                }
            }
        }

        public void RemoveAllFromRace()
        {
            _racingHorses.Clear();
        }
    }

}
