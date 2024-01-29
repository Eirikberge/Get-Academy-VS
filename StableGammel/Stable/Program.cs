using System.Diagnostics;

namespace Stable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var horses = new Horse[]
            {
                new Horse("Ponni1", 20),
                new Horse("Ponni2", 35),
                new Horse("Ponni3", 30),
            };
            var stable = new Stable();
            var race = new Race();

            stable.AddHorseToStable(horses[0]);
            stable.AddHorseToStable(horses[1]);
            stable.AddHorseToStable(horses[2]);

            stable.FeedHorse(horses[1]);
            stable.FeedHorse(horses[2]);

            race.AddToRacing(horses[0]);
            race.AddToRacing(horses[1]);
            race.AddToRacing(horses[2]);

            while (!race.IsRaceDone())
            {
                race.DoRacing();
                race.PrintWinner();
            }
            race.RemoveAllFromRace();

        }
    }
}
//  Du skal lage en stall, den skal ha noen hester. Hestene kan løpe i forskjellige hastigheter,
//    feks 20km/h, 30km/h og 35km/h. Du skal kunne mate
//    hesten, stelle med hesten og hesten skal kunne meldes på hesteløp. Under et hesteløp kan man ha en løkke
//    (for enkelhetsskyld kan hver runde i løkken tilsvare 1 time)
//    som går frem til en av hestene har vunnet. En hest skal løpe 3000km. Print ut hvor langt hestene har løpt per runde i løkken.