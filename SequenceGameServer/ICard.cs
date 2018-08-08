using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public interface ICard
    {
        ICardSuit Suit { get; }
        ICardValue Value { get; }
    }
}
