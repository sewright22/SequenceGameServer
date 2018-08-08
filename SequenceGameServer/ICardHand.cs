using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public interface ICardHand
    {
        void AddCard(ICard card);
        ICard GetCard(int position);
    }
}
