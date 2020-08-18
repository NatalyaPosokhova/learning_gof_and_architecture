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
        public bool CheckRuleCapabilities(Point point, ShipDirection direction, int deckQuantity)
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
        public void CreateShip(Point point, ShipDirection direction, int deckQuantity)
        {
            if(!CheckRuleCapabilities(point, direction, deckQuantity))
            {
                throw new CreateShipException();
            }
        }
    }
}
