using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public interface ICardSuit
    {
        string Value { get; }
        string Color { get; }
    }
}
