namespace TestIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var horseOne = new Horse("ponni", 20);
            var horseTwo = new Horse("ponni2", 25);
            var horseThree = new Horse("ponni3", 30);
            var stable = new Stable();

            stable.AddHorse(horseOne);
            stable.AddHorse(horseTwo);
            stable.AddHorse(horseThree);

            horseOne.FeedHorse(horseOne);

            horseOne.Race(horseOne);

            while (true)
            {
                if (horseOne.distanceRun <= 3000)
                {
                    horseOne.Run(horseOne);
                    Thread.Sleep(100);
                }
            }
        }
    }
}
//Du skal lage en stall, den skal ha noen hester. Hestene kan løpe i forskjellige hastigheter,
//feks 20km/h, 30km/h og 35km/h. Du skal kunne mate hesten,
//stelle med hesten og hesten skal kunne meldes på hesteløp.
//Under et hesteløp kan man ha en løkke (for enkelhetsskyld kan
//hver runde i løkken tilsvare 1 time) 
//som går frem til en av hestene har vunnet. En hest skal løpe 3000km.
//Print ut hvor langt hestene har løpt per runde i løkken.