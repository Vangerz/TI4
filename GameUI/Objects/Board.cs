using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI4_GameEngine.Objects
{
    public enum Systems
    {
        Atlas,
        Rigel,
    }

    public enum Planets
    {
        Atlas,
        Rigel_1,
        Rigel_2,
        Rigel_3,
    }

    class Board
    {
        public List<Objects.Player> Players; //Might remove since the game object will know the players
        public List<Objects.System> Systems;

        public Board(List<Objects.Player> lobbyPlayers, List<Objects.System> gameSystems)
        {
            Systems = gameSystems;
            Players = lobbyPlayers;
        }
    }

    class System
    {
        public required string Name;
        public required string System_Type; //Anomalies and the conditions of those...
        //public List<Objects.Planet> Planets; //Planet count will be in here, need a public get for the number of planets

        public System() 
        { 
        
        }

    }

    class Planet
    {
        public required string Name;
        public required int ProductionValue;
        public required int InfluenceValue;
        public required string Planet_Type; //Industrial, Cultural, Hazard?

        //Player related
        //public required int owner_infantry;
        //public required int owner_mechs;
        //public required int owner_pds;
        //public required int owner_spacedock;
        //public required string owner_faction; //Needed for the mechs and infratry combat values and etc
        //public required int invading_infantry;
        //public required int invading_mechs;
        //public required int invading_pds;
        //public required int invading_spacedock;
        //public required string invading_faction; //Needed for the mechs and infratry combat values and etc

        public Planet() 
        { 
        
        }
    }
}
