namespace Gruppeoppgave_Resturant
{
    internal class Reservation
    {
        private readonly string _name;
        private readonly string _phoneNr;
        private int _numberOfGuest;
        public DateTime StartTime { get; }
        public Table Table { get; }

        public Reservation(string name, string phoneNr, int numberOfGuest, DateTime startTime, Table table)
        {
            _name = name;
            _phoneNr = phoneNr;
            _numberOfGuest = numberOfGuest;
            StartTime = startTime;
            Table = table;

        }

        public string GetDescription()
        {
            return $"Reservert bord til {_numberOfGuest} personer kl {StartTime:g}";
        }
    }
}