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
        /// <summary>
        /// Checks if the shot hits the ship.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool CheckShooting(Point point)
        {
            throw new NotImplementedException();
        }
        public Ship(Point position, ShipDirection direction, int deckQuantity)
        {
            this.Position = position;
            this.Direction = direction;
            this.DeckQuantity = deckQuantity;
            this.State = ShipState.Live;
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
