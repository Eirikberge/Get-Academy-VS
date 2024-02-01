

using System;

namespace HarryPotter
{
    internal class Letter
    {
        public string Name { get; private set; }
        private Character Reception;

        public Letter(string name, Character reception)
        {
            Name = name;
            Reception = reception;
        }

        public void WriteLetter(string text)
        {
            Name = text;
        }

        public string FindReceiver()
        {
            return Reception.Name;
        }
    }
}
