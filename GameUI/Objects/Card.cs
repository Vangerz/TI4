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

    /// <summary>
    /// Enumeration of all strategy card types
    /// </summary>
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

    //Action cards need to populate the following 5 items:
    // Name, Number in deck, Play condition, Effect (Action), Flavor Text

    //

    abstract class Card
    {
        /// <summary>
        /// Front of card
        /// </summary>
        required public BitmapImage Front;

        /// <summary>
        /// Back of card
        /// </summary>
        public BitmapImage Back = ImageResources.DefaultCardBackImage; // TODO: Default to specific image based on card type

        /// <summary>
        /// Owner of card (if applicable)
        /// </summary>
        public Player? Owner;

        /// <summary>
        /// List of players allowed to view card contents
        /// </summary>
        List<Player> SharedWith = new List<Player>();

        /// <summary>
        /// Default constructor; Should be overridden by child classes
        /// </summary>
        public Card()
        {
            // Default constructor
        }

        /// <summary>
        /// Action taken when card is played
        /// (This could be a one-time purge, exhaust, or once per window with conditions met)
        /// </summary>
        required public Action action;

        #region ShowToPlayers
        /// <summary>
        /// Shows card to the specified player
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool ShowCardTo(Objects.Player player)
        {
            // TODO: Manager to track if it was viewed/seen,
            // Timeout before removing permission to view,
            // Return true if visibility changed,false if nothing changed
            if(!SharedWith.Contains(player))
            {
                SharedWith.Add(player);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Shows card to all players in the game
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public bool ShowCardToAll(Objects.Board board)
        {
            // Shows card to all players in the game; Returns true if any new players were shown the card
            return ShowCardToXPlayers(board.Players);
        }
        /// <summary>
        /// Shows card to a list of players
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        public bool ShowCardToXPlayers(List<Objects.Player> players)
        {
            bool newPlayerShownCard = false;
            // Shows card to a list of players. Returns true if any new players were shown the card
            foreach (Objects.Player player in players)
            {
                newPlayerShownCard |= ShowCardTo(player);
            }
            return newPlayerShownCard;
        }
        #endregion ShowToPlayers
    }

    class StrategyCard : Card
    {
        public StrategyTypes StrategyType;
        public StrategyCard(StrategyTypes stratCard) : base()
        {
            StrategyType = stratCard;
            switch (stratCard)
            {
                case StrategyTypes.LEADERSHIP:
                    Front = ImageResources.Leadership;
                    // TODO: Assign leadership action method to action
                    break;
                case StrategyTypes.DIPLOMACY:
                    Front = ImageResources.Diplomacy;
                    // TODO: Assign action
                    break;
                case StrategyTypes.POLITICS:
                    Front = ImageResources.Politics;
                    // TODO: Assign action
                    break;
                case StrategyTypes.CONSTRUCTION:
                    Front = ImageResources.Construction;
                    // TODO: Assign action
                    break;
                case StrategyTypes.TRADE:
                    Front = ImageResources.Trade;
                    // TODO: Assign action
                    break;
                case StrategyTypes.WARFARE:
                    Front = ImageResources.Warfare;
                    // TODO: Assign action
                    break;
                case StrategyTypes.TECHNOLOGY:
                    Front = ImageResources.Technology;
                    // TODO: Assign action
                    break;
                case StrategyTypes.IMPERIAL:
                    Front = ImageResources.Imperial;
                    // TODO: Assign action
                    break;
                default:
                    throw new NotImplementedException("TBD Generic Strategy Card");
            }
        }

    }
}
