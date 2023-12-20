
namespace FallingParticles
{
    internal class Paddle
    {
        public int PaddlePosition { get; set; }
        public int PaddleMoveDistance { get; }
        public string myPaddle { get; }

        public Paddle(int paddlePosition = 0, int paddleMoveDistance = 6, string paddle = "========")
        {
            PaddlePosition = paddlePosition;
            PaddleMoveDistance = paddleMoveDistance;
            myPaddle = paddle;
        }

        public void MovePaddle()
        //Det er vanlig å plassere logikken for hvordan en padle beveger seg i Paddle-klassen.
        //Metoden MovePaddle bør være en del av Paddle-klassen fordi den håndterer selve bevegelsen til padlen.
        //      Imidlertid kan det være nyttig å ha en kobling mellom MovePaddle-metoden i
        //Paddle-klassen og selve spillet(Game-klassen). 
        //Game-klassen kan inneholde koden som kalles for å bevege padlen, 
        //basert på spillerens input eller andre spillrelaterte hendelser.
        //Slik kan spillet kontrollere og oppdatere padlens posisjon ved
        //å bruke MovePaddle-metoden som er definert i Paddle-klassen.
        //      Dette lar Paddle-klassen ha ansvaret for hvordan padlen beveger seg,
        //mens Game-klassen styrer når og hvordan denne bevegelsen faktisk skjer i
        //spillmiljøet.Dette følger prinsippet om at hver klasse har sitt eget
        //ansvarsområde og at ansvar for spillmekanikken holdes adskilt fra den
        //direkte implementasjonen av spillobjekter.
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                var moveLeft = key.Key == ConsoleKey.LeftArrow && PaddlePosition >= PaddleMoveDistance;
                var moveRight = key.Key == ConsoleKey.RightArrow && PaddlePosition < Console.WindowWidth - myPaddle.Length;
                if (moveLeft || moveRight)
                {
                    var direction = moveLeft ? -1 : 1;
                    PaddlePosition += direction * 3 * myPaddle.Length / 4;
                }
            }
        }
    }
}
