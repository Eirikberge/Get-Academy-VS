namespace HarryPotter
{
    internal class Character
    {
        public string Name { get; private set; }
        public string House { get; private set; }
        public List<Item> _items;

        public Character(string name, string house)
        {
            Name = name;
            House = house;
            _items = new List<Item>();
            
        }
    }
}
