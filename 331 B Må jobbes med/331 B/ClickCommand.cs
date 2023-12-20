using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _331_B
{
    internal class ClickCommand : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = ' ';
        public void Run()
        {
            throw new NotImplementedException();
        }

        
    }
}
