namespace Colors
{
    internal class Color
    {
        private ConsoleColor _color;

        public Color()
        {
            _color = ConsoleColor.DarkGreen;
        }

        public void PreviousColor()
        {
            _color--;
        }

        public void NextColor()
        {
            _color++;
        }

        public ConsoleColor GetConsoleColor()
        {
            return _color;
        }
        //Annen mulighet for denne?

        public void InvertColor()
        {
            var colorNumber = (int)_color;
            colorNumber = 15 - colorNumber;
            _color = (ConsoleColor)colorNumber;
        }

        public void DarkeningColor()
        {
            var colorName = _color.ToString();
            colorName = "Dark" + colorName;
            var isSuccess = ConsoleColor.TryParse(colorName, out _color);
        }

        public void LightningColor()
        {
            var colorName = _color.ToString();
            if (colorName.Contains("Dark"))
            {
                colorName = colorName.Substring(4);
                _color = Enum.Parse<ConsoleColor>(colorName);
            }
        }

        public void SetColor()
        {
            Console.BackgroundColor = (ConsoleColor)_color;
            Console.ForegroundColor = (ConsoleColor)(15 - (int)_color);
        }
    }

}
