using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public interface IGameBoardSpace
    {
        ICard Card { get; }
        IGamePiece GamePiece { get; }
        bool IsOccupied { get; }
        void PlaceGamePiece(IGamePiece gamePiece);
        IGamePiece RemoveGamePiece();
    }
}
