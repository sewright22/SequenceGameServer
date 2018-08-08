using AutoFixture.Xunit2;
using Moq;
using SequenceGameServer;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SequenceGameUnitTests
{
    public class CardTests
    {
        [Theory, AutoMoqData]
        public void CardCreationTest(Mock<ICardSuit> mockCardSuit, Mock<ICardValue> mockCardValue)
        {
            var card = new Card(mockCardSuit.Object, mockCardValue.Object);
            Assert.Equal(mockCardSuit.Object, card.Suit);
            Assert.Equal(mockCardValue.Object, card.Value);
        }
    }
}
