namespace CarRace
{
    internal class Garage
    {
        private List<Car> _carsInGarage;

        public Garage()
        {
            _carsInGarage = GetCars();
        }
        private List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car("Eirik", "Mercedes"),
                new Car("Per", "Ferrari"),
                new Car("Pål", "Masarati"),
                new Car("Askeladden"),
            };
        }
        public List<Car> GetCarsInGarage() => _carsInGarage;
    }
}
