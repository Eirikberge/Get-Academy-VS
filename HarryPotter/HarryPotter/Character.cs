using System.Buffers;
using System.IO.Enumeration;

namespace HarryPotter
{
    internal class Character
    {
        public string Name { get; private set; }
        public string House { get; private set; }
        public int CharacterId { get; private set; }
        public List<Item> _items { get; private set; }
        public List<Letter> _letters { get; private set; }
        public Owl Owl;

        private Letter letter;

        public Character(string name, string house, int characterId)
        {
            Name = name;
            House = house;
            _items = new List<Item>();
            _letters = new List<Letter>();
            CharacterId = characterId;
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

        public void Makeletter(Character receiver)
        {
            var letter = new Letter("test", receiver);
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

        public void AddLetterToInventory(Letter letter)
        {
            _letters.Add(letter);
        }

        public void OpenLetters()
        {
            foreach (var letter in _letters)
            {
                Console.WriteLine($"{letter.Name}");
            }
        }
        public void ShowCharacterInfo()
        {
            Console.Clear();
            Console.WriteLine($"Navn: {Name}");
            Console.WriteLine($"Hus: {House}");
            ShowItems();
        }
        private void ShowItems()
        {
            Console.WriteLine("Items:");
            foreach (var item in _items)
            {
                Console.WriteLine($" - {item.Name}");
            }
        }
    }
}
