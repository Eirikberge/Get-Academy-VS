namespace Gruppeoppgave_Resturant
{
    internal class Restaurant
    {
        private string _name;
        private int _openTime;
        private int _closeTime;
        private TimeSpan DefaultReservationDuration = TimeSpan.FromHours(2);
        private List<Table> _tables;
        private List<Reservation> _reservations;
        private List<Table> _possibleTables;

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

        
        public ReservationResponse CreateReservation(string name, string phoneNr, int persons, DateTime arrivalTime)
        {
            var table = GetAvailibleTable(persons, arrivalTime);

            if (table == null)
            {
                return new ReservationResponse(persons, arrivalTime);
            }

            var reservation = new Reservation(name, phoneNr, persons, arrivalTime, table);
            _reservations.Add(reservation);
            return new ReservationResponse(reservation);
        }

        private Table GetAvailibleTable(int persons, DateTime arrivalTime)
        {
            var bigEnoughTables = _tables.Where(t => t.HasCapacity(persons));
            foreach (var table in bigEnoughTables)
            {
                if (isTableAvailable(table, arrivalTime))
                {
                    return table;
                }
            }
            return null;
        }

        private bool isTableAvailable(Table table, DateTime startTimeToCheck)
        {
            foreach (var reservation in _reservations)
            {
                if(reservation.Table != table) continue;
                var endTimeToCheck = startTimeToCheck.Add(DefaultReservationDuration);

                var reservationStartTime = reservation.StartTime;
                var reservationEndTime = reservation.StartTime.Add(DefaultReservationDuration);

                if (reservationEndTime >= startTimeToCheck && reservationStartTime <= endTimeToCheck)
                {
                    return false;
                }
            }
            return true;
        }

        public string GetAllReservationsForOneDay(DateTime date)
        {
            return "";
        }
    }
}
