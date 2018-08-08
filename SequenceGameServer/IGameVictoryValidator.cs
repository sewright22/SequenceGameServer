using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public interface IGameVictoryValidator
    {
        bool IsGameOver(IGameBoard gameBoard);
    }
}
