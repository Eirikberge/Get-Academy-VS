using System.Net.Mime;

namespace _318_B
{
    internal class Program
    {
        static string ReverseText(string Text)
        {
            string reversedText = "";
            for (var index = Text.Length - 1; index >= 0; index--)
            {
                var letter = Text[index]; 
                reversedText += letter;
            }
            return reversedText;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string Text = Console.ReadLine();
            string reversed = ReverseText(Text);
            Console.WriteLine(reversed);


        }
    }
}