namespace HarryPotter
{
    internal class MagicStore
    {
        public List<Item> petsList;
        public List<Item> wands;
        public Character Customer;

        public MagicStore()
        {
            petsList = new List<Item>() { new Item("Rotte", 1), new Item("Ugle", 2), new Item("Katt", 3) };
            wands = new List<Item>() { new Item("Føniksstav", 1), new Item("Unikornstav", 2), new Item("Trollstav", 3) };
        }

        public void ShowStore(Character customer)
        {
            Customer = customer; // for å få tak i den som er new
            Console.Clear();
            Console.WriteLine("Vil du se dyr(d) eller tryllestaver(t)?");
            var storecmd = Console.ReadLine();
            if (storecmd == "d")
            {
                Console.WriteLine("Pets:");
                foreach (Item item in petsList)
                {
                    Console.WriteLine($"{item.Id} - {item.Name}");
                }
            }
            if (storecmd == "t")
            {
                Console.WriteLine("\nWands:");
                foreach (Item item in wands)
                {
                    Console.WriteLine($"{item.Id} - {item.Name}");
                }
            }

            Console.WriteLine("Skriv inn nr til det du vil kjøpe?");
            var idCmd = Console.ReadLine();
            var idCmdInt = Convert.ToInt32(idCmd);
            BuyItem(storecmd, idCmdInt);

        }
        private void BuyItem(string Choice, int idChoice)
        {
            if (Choice == "d")
            {
                var selectedPet = petsList.Where(pet => pet.Id == idChoice).First();
                Customer.AddItemToCustomer(selectedPet);
            }
        }
    }


}
