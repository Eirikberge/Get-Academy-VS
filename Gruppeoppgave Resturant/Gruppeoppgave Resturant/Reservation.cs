namespace Gruppeoppgave_Resturant
{
    internal class Reservation
    {
        private string _name;
        private string _phoneNr;
        private int _numberOfGuest;
        private DateTime _dateTime;

        public Reservation(string name, string phoneNr, int numberOfGuest, DateTime dateTime)
        {
            _name = name;
            _phoneNr = phoneNr;
            _numberOfGuest = numberOfGuest;
            _dateTime = dateTime;

        }

        public string GetDescription()
        {
            //Denne skal vise innholdet i reservasjonen om den var gyldig
            // eller en feilmelding om den ikke er gyldig
            var arrivalTime = _dateTime.ToString();
            return $"Reservert bord til {_numberOfGuest} personer {_dateTime}";
        }


        public Restaurant GetReservation()
        {
            //Denne skal settes til null om den ikke finner noen reservasjon
        }
    }
}
