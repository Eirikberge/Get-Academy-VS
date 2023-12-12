using System.Drawing;

namespace Gruppeoppgave_Resturant
{
    internal class Table
    {
        private string Name;
        public int Size { get; }
        public bool IsTaken { get; set; }
        //Denne er set; slik at vi kan endre den når et bord er opptatt

        public Table(string name, int size, bool IsTaken = false)
        {
            Name = name;
            Size = size;
        }

        public string GetDescription()
        //Denne brukes til linje 11 og 12 i program
        {
            var description = $"Bord {Name} har plass til {Size} personer";
            return description;
        }
    }
}
