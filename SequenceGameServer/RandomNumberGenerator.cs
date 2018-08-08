using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private static Random rng = new Random();

        public int Generate(int maxValue)
        {
            return rng.Next(maxValue);
        }
    }
}
