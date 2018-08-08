using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public interface IGameBoard
    {
        void PlaceGamePiece(int location, IGamePiece gamePiece);
        IGamePiece RemoveGamePiece(int location);
    }
}
