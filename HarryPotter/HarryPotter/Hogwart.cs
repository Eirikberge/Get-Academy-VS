namespace HarryPotter
{
    internal class Hogwart
    {
        public List<Character> _characters;
        private MagicStore _magicStore;
        private Character _currentCharacter;

        public Hogwart()
        {
            _characters = Characters();
        }

        public void Run()
        {
            var nr = 1;
            while (true)
            {
                var cmd = Console.ReadLine();
                if (string.IsNullOrEmpty(cmd))
                {
                    Console.WriteLine("Hvilken karakter vil du benytte?");
                    foreach (var character in _characters)
                    {
                        Console.WriteLine($"{nr++} - {character.Name}");
                    }
                }
                else if (cmd == "1")
                {
                    _currentCharacter = _characters[0];
                }
                else if (cmd == "2")
                {
                    _currentCharacter = _characters[1];
                }
                else if (cmd == "3")
                {
                    _currentCharacter = _characters[2];
                }
                ShowCharacterInfo();
                if (cmd == "10 ")
                {
                    Run();
                }
            }

        }

        private List<Character> Characters()
        {
            return new List<Character>()
            {
                new Character("Harry", "Gryffindor"),
                new Character("Ronald", "Gryffindor"),
                new Character("Hermione", "Gryffindor"),
            };
        }

        private void ShowCharacterInfo()
        {
            Console.Clear();
            Console.WriteLine($"Navn: {_currentCharacter.Name}");
            Console.WriteLine($"Hus: {_currentCharacter.House}");
            ShowItems();
            Console.WriteLine("10 = Bytt karakter");
        }

        private void ShowItems()
        {
            Console.WriteLine("Items:");
            foreach (var item in _currentCharacter._items)
            {
                Console.WriteLine($" - {item.Name}");
            }
        }
    }
}
