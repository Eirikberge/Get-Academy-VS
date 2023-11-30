namespace Car_Collection
{
    internal class Car
    {
        public string Brand;
        public string Country;
        public int FoundedYear;
        public int AnnualProduction;

        public Car(string brand, string country, int foundedYear, int annualProduction)
        {
            Brand = brand;
            Country = country;
            FoundedYear = foundedYear;
            AnnualProduction = annualProduction;
        }
    }

}