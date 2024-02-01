
namespace HarryPotter
{
    internal class Owl
    {
        public string Name;
        public Letter Letter;

        private Hogwart Hogwart;
        private Character character;

        public Owl(string name)
        {
            Name = name;
        }

        public void FlyingOwl()
        {

        }

        public void FindReceiver(Letter letter)
        {
            if (Hogwart.FoundReceiver())
            {
                DeliverLetter(letter);
            }
            Console.WriteLine("Fant ingen mottaker med det navnet");
        }

        public void DeliverLetter(Letter letter)
        {
            character.AddLetterToInventory(letter);
        }

        public void GiveToOwl(Letter letter)
        {
            Letter = letter;
            FindReceiver(letter);
        }
    }
}
