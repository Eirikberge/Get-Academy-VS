var range = 250;
var counts = new int[range]; // oppretter array av heltall
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine()?.ToLower();
    foreach (var character in text ?? string.Empty)
    {
        counts[(int)character]++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            Console.WriteLine(character + " - " + counts[i]);
        }
    }
}   