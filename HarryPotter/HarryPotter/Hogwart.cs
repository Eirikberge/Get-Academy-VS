using System.ComponentModel;
using System.ComponentModel.Design;

namespace HarryPotter
{
    internal class Hogwart
    {
        public List<Character> _characters;
        private MagicStore _magicStore;
        private Character _currentCharacter;
        public List<Item> magicSpells;

        public Letter letter;

        public Hogwart(MagicStore magicStore)
        {
            _characters = Characters();
            var nr = 1;
            _magicStore = magicStore; // merk merk
            magicSpells = new List<Item>() { new Item("Vingardium Leviosa", 1), new Item("Hokus Pokus", 2) };
        }

        public void Run()
        {
            while (true)
            {
                if (_currentCharacter == null)
                {
                    StartCharacter();
                }
                Console.WriteLine("\n Hva vil du gjøre?\n 1. Gå til Magic Store\n 2. Velge ny karakter");
                var cmd2 = Console.ReadLine();
                if (cmd2 == "1")
                {
                    _magicStore.ShowStore(_currentCharacter);
                }
                else if (cmd2 == "2") StartCharacter();
                else if (CheckIfMagic(cmd2)) DoMagic(cmd2);
                else if (cmd2 == "3")
                {
                    if (_currentCharacter.CheckIfOwl())
                    {
                        Console.WriteLine("hvem vil du sende til?");
                        var reciverCmd = Console.ReadLine();
                        _currentCharacter.Makeletter(_characters[1]);
                        // først lage brevet klasse: Character WriteLetter()
                        // skrive brevet klasse: Character
                        // velge mottaker klasse: Character
                        // gi det til ugla klasse: Character
                        // ugla flyr klasse: ugle
                        // legge det til motaker sin inv/postkassa klasse: ulge og character

                    }
                }
            }
        }

        private void DoMagic(string cmd2)
        {
            var spellEffects = new SpellEffects();
            foreach (var spell in magicSpells)
            {
                if (cmd2 == spell.Name)
                {
                    if (CheckIfMagic(cmd2))
                    {
                        if (cmd2 == "Vingardium Leviosa" || cmd2 == spell.Name[0].ToString())
                        {
                            Console.WriteLine("En fjær flyr!");
                            Thread.Sleep(5000);
                        }
                        else if (cmd2 == "Hokus Pokus") spellEffects.ShowFireworks();
                    }
                    else Console.WriteLine("Ugyldig trylleformel");
                }
                ShowCharacterInfo();
            }
        }

        private bool CheckIfMagic(string intputSpell)
        {
            foreach (var spell in magicSpells)
            {
                if (intputSpell == spell.Name) return true;
            }
            return false;
        }

        private void StartCharacter()
        {
            Console.Clear();
            Console.WriteLine("Hvilken karakter vil du benytte?");
            var nr = 1;
            foreach (var character in _characters)
            {
                Console.WriteLine($"{nr++} - {character.Name}");
            }

            var cmd = Console.ReadLine();
            var cmdInt = Convert.ToInt32(cmd);
            for (var i = 0; i < _characters.Count; i++)
            {
                if (cmdInt == i + 1) _currentCharacter = _characters[i];
            }
            ShowCharacterInfo();
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

        private void ShowCharacterInfo() // flytte
        {
            Console.Clear();
            Console.WriteLine($"Navn: {_currentCharacter.Name}");
            Console.WriteLine($"Hus: {_currentCharacter.House}");
            ShowItems();
        }

        private void ShowItems() // flytter den over
        {
            Console.WriteLine("Items:");
            foreach (var item in _currentCharacter._items)
            {
                Console.WriteLine($" - {item.Name}");
            }
        }

        public bool FoundReceiver()
        {
            foreach (var character in _characters)
            {
                if (character.Name == letter.FindReceiver()) return true;
            }
            return false;
        }
    }
}
