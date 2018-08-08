using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public interface IMoveValidator
    {
        bool IsValidMove(int location, IGamePiece piece);
    }
}
