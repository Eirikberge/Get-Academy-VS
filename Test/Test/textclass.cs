namespace Test
{
    internal class textclass
    {
        string _text ;
        int _count = 0;

        public textclass(string text, int count = 0)
        {
            _text = text;
            _count = 0;
        }


        public void CharCounter()
        {
            string[] listedText = _text.Split(' ');

            foreach (char tegn in _text)
            {
                if (char.IsLetter(tegn))
                {
                    _count++;
                }
            }
            Console.WriteLine($"Det er {_count} bokstaver i teksten");
            Console.WriteLine($"Det er {listedText.Length} ord i teksten");
        }
    }
}
