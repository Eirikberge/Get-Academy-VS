namespace Car_Collection
{
    internal class Garage
    {
        private Car[] _cars;

        public Garage()
        {
            _cars = new Car[]
            {
                new Car("Toyota", "Japan", 1937, 10000000),
                new Car("BMW", "Germany", 1916, 2000000),
                new Car("Ford", "United States", 1903, 6000000),
                new Car("Volvo", "Sweden", 1927, 600000),
                new Car("Ferrari", "Italy", 1939, 10000),
                new Car("Tesla", "United States", 2003, 500000),
                new Car("Honda", "Japan", 1948, 5000000),
                new Car("Mercedes-Benz", "Germany", 1926, 2500000),
                new Car("Volkswagen", "Germany", 1937, 6000000),
                new Car("Chevrolet", "United States", 1911, 4000000),
                new Car("Audi", "Germany", 1910, 1800000),
                new Car("Nissan", "Japan", 1933, 5000000),
                new Car("Peugeot", "France", 1889, 2200000),
                new Car("Hyundai", "South Korea", 1967, 5000000),
                new Car("Kia", "South Korea", 1944, 3000000),
                new Car("Subaru", "Japan", 1953, 1000000),
                new Car("Mitsubishi", "Japan", 1970, 1200000),
                new Car("Lamborghini", "Italy", 1963, 8000),
                new Car("Maserati", "Italy", 1914, 20000),
                new Car("Porsche", "Germany", 1931, 350000),
                new Car("Jaguar", "United Kingdom", 1922, 200000),
                new Car("Land Rover", "United Kingdom", 1948, 400000),
                new Car("Mini", "United Kingdom", 1959, 350000),
                new Car("Rolls-Royce", "United Kingdom", 1904, 4000),
                new Car("Bentley", "United Kingdom", 1919, 10000),
                new Car("McLaren", "United Kingdom", 1963, 5000),
                new Car("Bugatti", "France", 1909, 10000),
                new Car("Lotus", "United Kingdom", 1952, 15000),
                new Car("Alfa Romeo", "Italy", 1910, 150000),
            };
        }

        public Car[] GetCars()
        {
            return _cars;
        }
    }
}
