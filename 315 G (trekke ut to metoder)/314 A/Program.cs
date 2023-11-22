using System;
using static System.Net.Mime.MediaTypeNames;

namespace Eirik
{
    class Program
    {
        // function main(arguments)
        static void Print(int range, int[]counts)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i]);
                }
            }
        }
        static void Count(string? text, int[] counts)
        {
            foreach (var character in text)
            {
                counts[(int)character]++;
            }
        }
        static void Main(string[] arguments)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToLower();

                Count(text, counts);

                Print(range, counts);
            }
        }
    }
}