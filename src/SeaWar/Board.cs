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
        public bool CheckRuleCapabilities(Point candidatePoint, int candidateDeckQuantity, ShipDirection candidateDirection)
        {
            bool result = true;

            //Check that there are no other ships in this place
            foreach(Ship currentShip in shipsList)
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
                            result = false;
                        }
                    }
            }

            //Check that currentShip is inside borders
            if(candidateDirection == ShipDirection.Vertical)
            {
                if((candidatePoint.y + candidateDeckQuantity - 1) >= boardSize)
                {
                    result = false;
                }
            }
            else
            {
                if((candidatePoint.x + candidateDeckQuantity - 1) >= boardSize)
                {
                    result = false;
                }
            }
            return result;
        }
        public void CreateShip(Point point, int deckQuantity, ShipDirection direction)
        {
            if(!CheckRuleCapabilities(point, deckQuantity, direction))
            {
                throw new CreateShipException();
            }

            shipsList.Add(new Ship(point, deckQuantity, direction));
        }
    }
}
