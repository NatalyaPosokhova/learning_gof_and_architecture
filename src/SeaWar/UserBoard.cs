using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class UserBoard : Board
    {
        /// <summary>
        /// Check that ship is located inside boundaries
        /// </summary>
        /// <returns></returns>
        public bool IsShipInsideBoundaries(Point point, ShipDirection direction)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Determines whether another ship is already located at this place
        /// </summary>
        /// <param name="point"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool IsAnotherShipLocatedAtThisPlace(Point point, ShipDirection direction)
        {
            throw new NotImplementedException();
        }
    }
}
