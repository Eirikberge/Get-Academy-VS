

namespace HarryPotter
{
    internal class Letter
    {
        public string Name { get; private set; }
        private Character Reciption;

        public Letter(string name, Character reciption)
        {
            Name = name;
            Reciption = reciption;
        }

        public void WriteLetter( string text)
        {
            Name = text;
        }
    }
}
