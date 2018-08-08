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
            Assert.True(deck.CardsRemaining == 0);
        }

        [Theory, AutoMoqData]
        public void AddCardToDeckTest(Mock<IRandomNumberGenerator> mockRandomNumberGenerator)
        {
            var deck = new Deck(mockRandomNumberGenerator.Object);
            deck.AddCard(Mock.Of<ICard>());
            deck.AddCard(Mock.Of<ICard>());
            deck.AddCard(Mock.Of<ICard>());
            Assert.True(deck.CardsRemaining==3);
        }

        [Theory, AutoMoqData]
        public void DrawCardToDeckTest(Mock<IRandomNumberGenerator> mockRandomNumberGenerator)
        {
            var deck = new Deck(mockRandomNumberGenerator.Object);
            deck.AddCard(Mock.Of<ICard>(x => x.Value == Mock.Of<ICardValue>(v => v.Value == EnumCardValue.ACE)));
            deck.AddCard(Mock.Of<ICard>(x => x.Value == Mock.Of<ICardValue>(v => v.Value == EnumCardValue.TWO)));
            deck.AddCard(Mock.Of<ICard>(x => x.Value == Mock.Of<ICardValue>(v => v.Value == EnumCardValue.QUEEN)));
            Assert.True(deck.CardsRemaining == 3);
            var actual = deck.Draw();
            Assert.True(deck.CardsRemaining == 2);
            Assert.True(actual.Value.Value == EnumCardValue.QUEEN);
            actual = deck.Draw();
            Assert.True(deck.CardsRemaining == 1);
            Assert.True(actual.Value.Value == EnumCardValue.TWO);
            actual = deck.Draw();
            Assert.True(deck.CardsRemaining == 0);
            Assert.True(actual.Value.Value == EnumCardValue.ACE);
        }

        [Theory, AutoMoqData]
        public void ShuffleDeckTest(Mock<IRandomNumberGenerator> mockRandomNumberGenerator)
        {
            mockRandomNumberGenerator.Setup(x => x.Generate(1));
            var deck = new Deck(mockRandomNumberGenerator.Object);
            deck.AddCard(Mock.Of<ICard>());
            deck.AddCard(Mock.Of<ICard>());
            deck.Shuffle();
            mockRandomNumberGenerator.Verify(x => x.Generate(2), Times.Exactly(2));
        }
    }
}
