using System;

namespace _318_D
{
    internal class Program
    {
        static int Counter(int start, int end)
        {
            int counter = 0;
            for (int i = start; i <= end; i += 10)
            {
                Console.WriteLine(i);
                counter++;
            }
            return counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter start number:");
            int startNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end number:");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            int result = Counter(startNumber, endNumber);
            Console.WriteLine("Count: " + result);
        }
    }
}