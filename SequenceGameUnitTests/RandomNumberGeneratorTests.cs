using SequenceGameServer;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SequenceGameUnitTests
{
    public class RandomNumberGeneratorTests
    {
        [Fact]
        public void GenerateNumberTest()
        {
            var generator = new RandomNumberGenerator();
            var startList = new List<int>();
            var numsUsed = new List<int>();

            for(int i=1;i<=52;i++)
            {
                startList.Add(i);
            }

            for (int i = 1; i <= 52; i++)
            {
                var actual = generator.Generate(startList.Count);
                Assert.True(actual < startList.Count && actual > -1);
                var numRemoved = startList[actual];
                Assert.DoesNotContain(numRemoved, numsUsed);
                numsUsed.Add(numRemoved);
                startList.RemoveAt(actual);
            }
        }
    }
}
