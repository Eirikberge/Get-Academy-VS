
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

        public void DeliverLetter(Letter letter)
        {
            letter.Receiver.AddLetterToInventory(letter);
            // letter. fungerer pga Letter har "public Character Receiver;"
        }

        public void GiveToOwl(Letter letter)
        {
            Letter = letter;
            DeliverLetter(letter);
        }
    }
}
