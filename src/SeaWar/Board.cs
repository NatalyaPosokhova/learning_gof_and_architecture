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
        public bool CheckRuleCapabilities(Point point, int deckQuantity, ShipDirection direction)
        {
            bool result = true;
            if(direction == ShipDirection.Vertical)
            {
                if((point.y + deckQuantity) >= boardSize)
                {
                    result = false;
                }
            }
            else
            {
                if((point.x + deckQuantity) >= boardSize)
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
            Ship ship = new Ship(point, deckQuantity, direction);
        }
    }
}
