
namespace HarryPotter
{
    internal class Letter
    {
        public string Name { get; private set; }
        public Character Receiver;

        public Letter(string name, Character receiver)
        {
            Name = name;
            Receiver = receiver;
        }
        public void WriteLetter(string text)
        {
            Name = text;
        }
    }
}
