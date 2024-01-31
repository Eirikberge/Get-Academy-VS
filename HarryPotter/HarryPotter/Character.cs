using System.Buffers;
using System.IO.Enumeration;

namespace HarryPotter
{
    internal class Character
    {
        public string Name { get; private set; }
        public string House { get; private set; }
        public List<Item> _items;
        public List<Letter> _letters;
        public Owl Owl;

        public Character(string name, string house)
        {
            Name = name;
            House = house;
            _items = new List<Item>();
            _letters = new List<Letter>();
        }

        public void AddItemToCustomer(Item selectedPet)
        {
            _items.Add(selectedPet);
        }

        public bool CheckIfOwl()
        {
            foreach (Item item in _items)
            {
                if (item.Name == "Ugle") return true;
            }
            return false;
        }

        public void Makeletter(Character reciver)
        {
            var letter = new Letter("test", reciver);
            WriteLetter(letter);
        }

        public void WriteLetter(Letter letter)
        {
            Console.WriteLine("Skriv brev:");
            var writingText = Console.ReadLine();
            letter.WriteLetter(writingText);
            SendLetter(letter);
        }


        public void SendLetter(Letter letter)
        {
            Owl = new Owl("Hedwig");
            Owl.GiveToOwl(letter);
        }

        public void AddLetterToInventory()
        {

        }
    }
}
