using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public interface IGame
    {
        void AddPlayer(IPlayer player);
        void Start();
        void AdvanceTurn();
    }
}
