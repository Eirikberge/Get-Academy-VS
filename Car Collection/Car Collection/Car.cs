namespace Car_Collection
{
    internal class Car
    {
        public string Brand { get; }
        public string Country { get; }
        public int FoundedYear { get; }
        public int AnnualProduction { get; }

        public Car(string brand, string country, int foundedYear, int annualProduction)
        {
            Brand = brand;
            Country = country;
            FoundedYear = foundedYear;
            AnnualProduction = annualProduction;
        }
    }

}