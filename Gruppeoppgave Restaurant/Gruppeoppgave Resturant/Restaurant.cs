namespace Gruppeoppgave_Resturant
{
    internal class Restaurant
    {
        private string _name;
        private int _openTime;
        private int _closeTime;
        private List<Table> _tables;
        private List<Reservation> _reservations;

        public Restaurant(string name, int openTime, int closeTime)
        {
            _name = name;
            _openTime = openTime;
            _closeTime = closeTime;
           _tables = new List <Table> ();
           _reservations = new List <Reservation> ();
        }

        public Table AddTable(string tableName, int tableSize)
        {
            Table newTable = new Table(tableName, tableSize);
            _tables.Add(newTable);
            return newTable;
        }

        public Reservation CreateReservation(string name, string phoneNr, int persons, DateTime arrivalTime)
        {
            //Skal også gjøre så bordet er reservert i 2 timer.
            Reservation newReservation = new Reservation(name, phoneNr, persons, arrivalTime);
            _reservations.Add(newReservation);
            return newReservation;
        }
    }
}
