namespace HarryPotter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var magicStore = new MagicStore();
            var hogwarts = new Hogwart(magicStore);
            
            hogwarts.Run();
        }
    }
}
//Harry Potter oppgave!

//Du skal starte med å lage en harrypotter character klasse med egenskaper som er unike for hvordan de kan beskrives, eller hva de kan eie eller hva de kan gjøre.

//Eksempler er: 
//House: huffelpuff, griffindor, slytherin, ravenclaw
//Items: wand, owl, etc

//Få applikasjonen til å printe ut en introduksjon for charakteren, som sier noe om hva de heter, hvilket hus de er medlem av og hvilke items de har

//Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:  ugle, rotte eller en katt. De har også mulighet til å kjøpe en tryllestav: føniksstav, unikornstav eller trollstav. For å få til dette må du lage en egen klasse som er butikken, og presentere brukeren med en meny for hva personen skal kjøpe.

//    Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
//trylleformler: 
//vingardium leviosa(får en fjær til å fly)
//hokus pokus(fyrer av fyrverkerier)

//Dersom en karakter har en ugle, har de mulighet til å sende et brev med uglen til en annen karakter. Karakteren som mottar brevet, får da brevet i inventoryen. Et brev inneholder en melding.