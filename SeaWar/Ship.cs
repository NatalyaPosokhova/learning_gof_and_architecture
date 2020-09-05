using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    /// <summary>
    /// Implement Ship
    /// </summary>
    public class Ship
    {
        public override bool Equals(object anotherObj)
        {
            var toCompareWith = anotherObj as Ship;
            if (toCompareWith == null)
                return false;
            return DeckQuantity == toCompareWith.DeckQuantity &&
                   Position.x == toCompareWith.Position.x &&
                   Position.y == toCompareWith.Position.y &&
                   Direction == toCompareWith.Direction;
        }

        //private int _deck;
        //int DeckQuantity
        //{
        //    get
        //    {
        //        return _deck;
        //    }
        //    set
        //    {
        //        _deck = value;
        //    }
        //}
        /// <summary>
        /// Returns Deck quantity
        /// </summary>
        public int DeckQuantity { get; private set; }
        /// <summary>
        /// Initial ship coordinates
        /// </summary>
        public Point Position { get; private set; }
        /// <summary>
        /// Determines the ship state.
        /// </summary>
        public ShipState State { get; private set; }
        /// <summary>
        /// Determines the ship direction.
        /// </summary>
        public ShipDirection Direction { get; private set; }
        private bool[] stateDeck = new bool[] { };
        /// <summary>
        /// Checks if the shot hits the ship.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool CheckShooting(Point point)
        {
            for (var currentDeck = 0; currentDeck < DeckQuantity; currentDeck++)
            {
                var currentPositionX = Position.x + (Direction == ShipDirection.Horizontal ? currentDeck : 0);
                var currentPositionY = Position.y + (Direction == ShipDirection.Horizontal ? 0 : currentDeck);

                if (currentPositionX == point.x && currentPositionY == point.y && stateDeck[currentDeck])
                {
                    stateDeck[currentDeck] = false;
                    if (stateDeck.Where((x) => x).Count() == 0)
                    {
                        State = ShipState.Died;
                    }
                    else
                    {
                        State = ShipState.Injured;
                    }
                    return true;
                }
            }
            return false;
        }
        public Ship(Point position, int deckQuantity, ShipDirection direction)
        {
            this.Position = position;
            this.DeckQuantity = deckQuantity;
            this.Direction = direction;
            this.State = ShipState.Live;
            this.stateDeck = Enumerable.Repeat(true, deckQuantity).ToArray();
        
        }
    }

    public enum ShipState {Live, Died, Injured};
    public enum ShipDirection { Vertical, Horizontal};
    public struct Point
    {
        public int x;
        public int y;
    }
}
