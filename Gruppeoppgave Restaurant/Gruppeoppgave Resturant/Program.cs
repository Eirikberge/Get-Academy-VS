namespace Gruppeoppgave_Resturant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Info: En bordreservasjon er på 2 timer
            var restaurant = new Restaurant("Terjes Trivelige Tapas", 16, 20);
            var tableA = restaurant.AddTable("A", 6);
            var tableB = restaurant.AddTable("B", 4);
            Console.WriteLine(tableA.GetDescription());
            Console.WriteLine(tableB.GetDescription());
            // Bord A har plass til 6 personer
            var dateTime = new DateTime(2023, 12, 24, 17, 0, 0);
            var reservationResponse1 = restaurant.CreateReservation("Olsen", "998 87 766", 5, dateTime);
            Console.WriteLine(reservationResponse1.GetDescription());
            // Reservert bord til 5 personer 24.12.2023 kl. 17:00
            var reservation1 = reservationResponse1.GetReservation();
            Console.WriteLine(reservation1.GetDescription());
            // Reservert bord til 5 personer 24.12.2023 kl. 17:00
            var reservationResponse2 = restaurant.CreateReservation("Hansen", "997 78 866", 5, dateTime);
            Console.WriteLine(reservationResponse2.GetDescription());
            // Vi beklager! Det er ikke ledig bord til 5 personer 24.12.2023 kl. 17:00
            var reservation2 = reservationResponse2.GetReservation();
            // Denne skal være null
            restaurant.CreateReservation("Nilsen", "994 48 866", 4, dateTime);
            var txt = restaurant.GetAllReservationsForOneDay(dateTime.Date);
            Console.WriteLine(txt);

        }
    }
}