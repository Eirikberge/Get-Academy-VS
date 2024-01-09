using System.Runtime.InteropServices;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "Hei på deg";
            var count = 0;

            foreach (var character in text)
            {
                if (character == 'e')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
