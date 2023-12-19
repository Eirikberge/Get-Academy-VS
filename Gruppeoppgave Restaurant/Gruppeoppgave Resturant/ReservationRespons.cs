namespace Gruppeoppgave_Resturant
{
    internal class ReservationResponse
    {
        private readonly Reservation _reservation;
        private int _persons;
        private DateTime _time;

        public ReservationResponse(Reservation reservation)
        {
            _reservation = reservation;
        }

        public ReservationResponse(int persons, DateTime time) 
        {
            _time = time;
            _persons = persons;
        }




        public string GetDescription()
        {
            if (_reservation == null)
            {
                return $"Vi beklager! Det er ikke ledig bord til {_persons} personer {_time:g}";
            }
            return _reservation.GetDescription();
        }

        public Reservation GetReservation()
        {
            return _reservation;
        }

    }
}
