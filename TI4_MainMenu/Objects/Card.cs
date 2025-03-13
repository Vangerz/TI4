using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TI4_GameEngine.Objects
{
    public enum CardTypes
    {
        DEFAULT_UNITIALIZED,
        PUBLIC_OBJECTIVE,
        PRIVATE_OBJECTIVE,
        ACTION,
        TECHNOLOGY,
        PROMISSORY,
        PLANET,
        RELIC_FRAGMENT,
        RELIC,

    }

    class Card
    {
        public string Tooltip = "Default Card Tool Tip";
        public string Title = "Default Card Title";
        public string Timing = "Default Card Timing Phase";
        public string Contents = "Default Card Contents";

        // Background images for card
        public Image Front;
        public Image Back;

        // Render front/back of card to display
        public Image FrontOfCard()
        {

        }
        public Image BackOfCard()
        {

        }

        public bool ConditionsMet()
        {
            // TODO: Card Conditions Met Check code
            Console.WriteLine("GENERIC CARD CONDITIONS. NOT IMPLEMENTED.");
            return false;
        }

        public object Action()
        {
            // TODO: Default card played/accomplished results
            Console.WriteLine("GENERIC CARD ACTION. NOT IMPLEMENTED.");
            return null;
        }

        public Card()
        {
            // TODO: Default Card Constructor
        }

        public bool ShowCardTo(Objects.Player player)
        {
            // TODO: Show Card to selected player only
            // TODO: Manager to track if it was viewed/seen,
            // Timeout before removing permission to view,
            // Return true/false if function succeeded in queing prompt/permission for player to view card

            return false;
        }

        public bool ShowCardToAll(Objects.Board board)
        {
            // TODO: Shows card to all players in the game
            return ShowCardToXPlayers(board.Players);
        }

        public bool ShowCardToXPlayers(List<Objects.Player> players)
        {
            bool shownToAll = true;
            // TODO: Shows card to a list of players
            foreach (Objects.Player player in players)
            {
                shownToAll &= ShowCardTo(player);
            }
            return shownToAll;
        }
    }
}
