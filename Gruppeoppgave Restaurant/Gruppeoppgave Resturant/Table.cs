using System.Drawing;

namespace Gruppeoppgave_Resturant
{
    internal class Table
    {
        private string Name;
        public int _size { get; }
        public Table(string name, int size)
        {
            Name = name;
            _size = size;
        }

        public string GetDescription()
        //Denne brukes til linje 11 og 12 i program
        {
            return $"Bord {Name} har plass til {_size} personer";
        }

        public bool HasCapacity(int persons)
        {
            return _size >= persons ;
        }
    }
}
