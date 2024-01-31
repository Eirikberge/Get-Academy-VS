
namespace HarryPotter
{
    internal class Owl
    {
        public string Name;
        public Letter Letter;

        public Owl(string name)
        {
            Name = name;
        }

        public void FlyingOwl()
        {

        }

        public void FindReciver()
        {
            //finne reciver,
            //feilmelding + hoppe et kort steg tilbake om navnet er feil
            // må gå igjenom lista med characters, 
            // finner den navnet, så sendes en godtkjent eller noe + navnet
            // til deliverLetter


        }

        public void DeliverLetter()
        {

        }

        public void GiveToOwl(Letter letter)
        {
            Letter = letter;
        }
    }
}
