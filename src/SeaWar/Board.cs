using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    /// <summary>
    /// Board for ships
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Sets the board type - user or rival
        /// </summary>
        public BoardType Type { get; private set; }
        /// <summary>
        /// Board size
        /// </summary>
        private const int size = 10;
        /// <summary>
        /// Determine name of every cell
        /// </summary>
        private char[] verticalNumeration = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};
        private int[] horisontalNumeration = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        /// <summary>
        /// Check that ship is located inside boundaries
        /// </summary>
        /// <returns></returns>
        public bool IsShipInsideBoundaries(Point point, ShipDirection direction)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Determines whether another ship is already located in this place
        /// </summary>
        /// <param name="point"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool IsAnotherShipLocatedAtThisPoint(Point point, ShipDirection direction)
        {
            throw new NotImplementedException();
        }
        public Board(BoardType type)
        {
            this.Type = type;
        }
    }
    /// <summary>
    /// Sets the Board Types
    /// </summary>
    public enum BoardType { User, Rival}
}
