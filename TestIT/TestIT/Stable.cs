namespace TestIT
{
    internal class Stable
    {
        public List<Horse> horseList;


        public Stable()
        {
            horseList = new List<Horse>();
        }


        public void AddHorse(Horse horse)
        {   
            horseList.Add(horse);
        }
    }
}
