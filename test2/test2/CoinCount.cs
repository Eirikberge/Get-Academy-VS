using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class CoinCount
    {
        private int Value;
        private int Count;

        public CoinCount(int value, int count)
        {
            Value = value;
            Count = count;
        }

        public int CalcValue()
        {
            return Value * Count;
        }
    }
}
