using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public class Card : ICard
    {
        private ICardSuit _suit;
        private ICardValue _value;

        public Card(ICardSuit suit, ICardValue value)
        {
            _suit = suit;
            _value = value;
        }

        public ICardSuit Suit => _suit;

        public ICardValue Value => _value;
    }
}
