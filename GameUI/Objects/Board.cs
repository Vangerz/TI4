using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI4_GameEngine.Objects
{
    class Board
    {
        public List<Objects.Player> Players;

        public Board(List<Objects.Player> lobbyPlayers)
        {
            Players = lobbyPlayers;
        }
    }
}
