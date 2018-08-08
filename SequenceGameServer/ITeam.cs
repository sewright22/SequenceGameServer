using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGameServer
{
    public interface ITeam
    {
        IDictionary<int, IPlayer> Players { get; }
    }
}
