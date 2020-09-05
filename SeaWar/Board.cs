using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class Board
    {
        private const int boardSize = 10;
        private List<Ship> shipsList = new List<Ship>();
        /// <summary>
        /// Checks that ship is mutch rules.
        /// </summary>
        /// <param name="candidatePoint">Ship candidate coordinates</param>
        /// <param name="candidateDeckQuantity">Ship candidate deck quantity</param>
        /// <param name="candidateDirection">Ship candidate direction</param>
        /// <returns>True if ship mutches rules, otherwise - false</returns>
        private bool CheckRuleCapabilities(Point candidatePoint, int candidateDeckQuantity, ShipDirection candidateDirection)
        {
            return IsShipNotCrossing(candidatePoint, candidateDeckQuantity, candidateDirection) &&
            IsShipInsideBounds(candidatePoint, candidateDeckQuantity, candidateDirection);
        }
        /// <summary>
        /// Checks that ship is not crossing with another ships.
        /// </summary>
        /// <param name="candidatePoint">Ship candidate deck quantity</param>
        /// <param name="candidateDeckQuantity">Ship candidate direction</param>
        /// <param name="candidateDirection">Ship candidate direction</param>
        /// <returns>True if ship is not crossing another ships, otherwise - false</returns>
        private bool IsShipNotCrossing(Point candidatePoint, int candidateDeckQuantity, ShipDirection candidateDirection)
        {
            //Check that there are no other ships in this place
            foreach (Ship currentShip in shipsList)
            {
                for (var candidateShipDeck = 0; candidateShipDeck < candidateDeckQuantity; candidateShipDeck++)
                    for (var currentShipDeck = 0; currentShipDeck < currentShip.DeckQuantity; currentShipDeck++)
                    {
                        var candidateX = candidatePoint.x + candidateDirection == ShipDirection.Horizontal ? candidateShipDeck : 0;
                        var candidateY = candidatePoint.y + candidateDirection == ShipDirection.Horizontal ? 0 : candidateShipDeck;
                        var currentX = currentShip.Position.x + currentShip.Direction == ShipDirection.Horizontal ? currentShipDeck : 0;
                        var currentY = currentShip.Position.y + currentShip.Direction == ShipDirection.Horizontal ? 0 : currentShipDeck;
                        if (candidateX == currentX && candidateY == currentY)
                        {
                            return false;
                        }
                    }
            }
            return true;
        }
        /// <summary>
        /// Checks that ship is inside borders.
        /// </summary>
        /// <param name="candidatePoint">Ship candidate deck quantity</param>
        /// <param name="candidateDeckQuantity">Ship candidate direction</param>
        /// <param name="candidateDirection">Ship candidate direction</param>
        /// <returns>True if ship is not crossing borders, otherwise - false</returns>
        private static bool IsShipInsideBounds(Point candidatePoint, int candidateDeckQuantity, ShipDirection candidateDirection)
        {
            var isVertical = candidateDirection == ShipDirection.Vertical;
            return ((isVertical ? candidatePoint.y : candidatePoint.x) + candidateDeckQuantity - 1) < boardSize;
        }

        /// <summary>
        /// Creates ship object if it matches rules.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="deckQuantity"></param>
        /// <param name="direction"></param>
        public void CreateShip(Point point, int deckQuantity, ShipDirection direction)
        {
            if (!CheckRuleCapabilities(point, deckQuantity, direction))
            {
                throw new CreateShipException("Coordinates don't match rules");
            }

            shipsList.Add(new Ship(point, deckQuantity, direction));
        }
        /// <summary>
        /// Makes shoot by ships on the board.
        /// </summary>
        /// <param name="shootCoord">Shoot point coordinates</param>
        public bool MakeShoot(Point shootCoord)
        {
            foreach (var currenShip in shipsList)
            {
                if (currenShip.CheckShooting(shootCoord))
                {
                    if (currenShip.State == ShipState.Died)
                    {
                        shipsList.Remove(currenShip);
                    }
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Checks that all ships were killed.
        /// </summary>
        /// <returns>True if all ships are died</returns>
        public bool IsAllShipsDied()
        {
            bool result = true;
            foreach (var currentShip in shipsList)
            {
                if (currentShip.State == ShipState.Live || currentShip.State == ShipState.Injured)
                {
                    result = false;
                }
            }
            return result;
        }
        public int GetShipsQuantity()
        {
            return shipsList.Count();
        }

        public Ship GetShip(Point position)
        {
            throw new NotImplementedException();
        }
    }
}
