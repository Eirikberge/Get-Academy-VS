namespace _341_B
{
    internal class CommandSet
    {
        private ICommand[] _commands;
        //Denne har en array med et objekt av hver kommando

        public CommandSet(ClickerGame game)
        {
            _commands = new ICommand[]
            {
                new IncreasePoints(game),
                new BuyUpgrade(game),
                new BuySuperUpgrade(game),
            };
        }
        public void Run(char commandChar)
        {
            var command = FindCommand(commandChar);
            if (command != null) command.Run();
        }

        private ICommand FindCommand(char commandChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == commandChar) return command;
            }

            return null;
        }
    }
}
