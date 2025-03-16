using GameUI.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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
        STRATEGY,
    }

    public enum StrategyTypes
    {
        LEADERSHIP,
        DIPLOMACY,
        POLITICS,
        CONSTRUCTION,
        TRADE,
        WARFARE,
        TECHNOLOGY,
        IMPERIAL
    }

    class Card
    {
        public string Tooltip = "Default Card Tool Tip";
        public string Title = "Default Card Title";
        public string Timing = "Default Card Timing Phase";
        public string Contents = "Default Card Contents";

        // Background images for card
        public BitmapImage Front;
        public BitmapImage Back;

        // Render front/back of card to display
        public BitmapImage FrontOfCard()
        {
            // TODO: Render partial bitmaps and text into a card image if there isn't one already
            Console.WriteLine("IMPLEMENT FRONT CARD RENDER");
            return Front;
        }
        public BitmapImage BackOfCard()
        {
            // TODO: Render partial bitmaps and text into a card image if there isn't one already
            Console.WriteLine("IMPLEMENT BACK CARD RENDER");
            return Back;
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

        public Card(CardTypes type)
        {
            throw new NotImplementedException("TODO: UNKNOWN CARD TYPE");

            // TODO: Default Card Constructor
            switch (type)
            {
                case CardTypes.DEFAULT_UNITIALIZED:
                    throw new NotImplementedException("TODO: UNKNOWN CARD TYPE");
                    break;
                case CardTypes.PUBLIC_OBJECTIVE:
                    break;
                case CardTypes.PRIVATE_OBJECTIVE:
                    break;
                case CardTypes.ACTION:
                    break;
                case CardTypes.TECHNOLOGY:
                    break;
                case CardTypes.PROMISSORY:
                    break;
                case CardTypes.PLANET:
                    break;
                case CardTypes.RELIC_FRAGMENT:
                    break;
                case CardTypes.RELIC:
                    break;
                case CardTypes.STRATEGY:
                    break;
                default:
                    break;
            }
        }

        public Card(StrategyTypes stratCard)
        {
            switch (stratCard)
            {
                case StrategyTypes.LEADERSHIP:
                    //Front = new BitmapImage(CommonEntities.ImageResources.Leadership);
                    Front = ImageResources.Leadership;
                    break;
                case StrategyTypes.DIPLOMACY:
                    Front = ImageResources.Diplomacy;
                    break;
                case StrategyTypes.POLITICS:
                    Front = ImageResources.Politics;
                    break;
                case StrategyTypes.CONSTRUCTION:
                    Front = ImageResources.Construction;
                    break;
                case StrategyTypes.TRADE:
                    Front = ImageResources.Trade;
                    break;
                case StrategyTypes.WARFARE:
                    Front = ImageResources.Warfare;
                    break;
                case StrategyTypes.TECHNOLOGY:
                    Front = ImageResources.Technology;
                    break;
                case StrategyTypes.IMPERIAL:
                    Front = ImageResources.Imperial;
                    break;
                default:
                    throw new NotImplementedException("TBD Generic Strategy Card");
                    break;
            }
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
