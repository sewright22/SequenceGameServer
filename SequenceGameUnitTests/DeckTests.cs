using Moq;
using SequenceGameServer;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SequenceGameUnitTests
{
    public class DeckTests
    {
        [Theory, AutoMoqData]
        public void CreateDeckTest(Mock<IRandomNumberGenerator> mockRandomNumberGenerator)
        {
            var deck = new Deck(mockRandomNumberGenerator.Object);
            Assert.True(deck.CardsRemaining==0);
        }

        [Theory, AutoMoqData]
        public void ShuffleDeckTest(Mock<IRandomNumberGenerator> mockRandomNumberGenerator)
        {
            mockRandomNumberGenerator.Setup(x => x.Generate(1));
            var deck = new Deck(mockRandomNumberGenerator.Object);
            deck.AddCard(Mock.Of<ICard>());
            deck.Shuffle();
            mockRandomNumberGenerator.Verify(x => x.Generate(deck.CardsRemaining), Times.Once);
        }
    }
}
