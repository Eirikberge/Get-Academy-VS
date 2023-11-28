namespace _321_A
{
    internal class CharCounter
    {
        private int[] _counts;

        public CharCounter(int range = 250)
        {
            _counts = new int[range];
        }

        public void AddText(string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                _counts[(int)character]++;
            }
        }

        public void ShowCounts()
        {
            for (var i = 0; i < _counts.Length; i++)
            {
                if (_counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + _counts[i]);
                }
            }
        }
    }
}
