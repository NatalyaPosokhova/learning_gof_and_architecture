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

            //Check that there are no other ships in this place
            foreach(Ship ship in shipsList)
            {
                if(ship.Direction == direction) //Ships have the same direction
                {
                    if(direction == ShipDirection.Vertical && point.x == ship.Position.x)//Ships are located on one vertical line
                    {
                        if(point.y > ship.Position.y && (ship.Position.y + ship.DeckQuantity - 1) >= point.y ||
                           point.y < ship.Position.y && (point.y + deckQuantity - 1) >= ship.Position.y      ||
                           point.y == ship.Position.y)
                        {
                            result = false;
                        }
                    }
                    else//Ships are located on one horizontal line
                    {
                        if (point.x > ship.Position.x && (ship.Position.x + ship.DeckQuantity - 1) >= point.x ||
                            point.x < ship.Position.x && (point.x + deckQuantity - 1) >= ship.Position.x      ||
                            point.x == ship.Position.x)
                        {
                            result = false;
                        }
                    }
                }
                else //Ships have different direction
                {
                    if (direction == ShipDirection.Vertical)
                    {
                        for(var firstShipDeck = point.y; firstShipDeck < point.y + deckQuantity; firstShipDeck++)
                        {
                            for (var secondShipDeck = ship.Position.x; secondShipDeck < ship.Position.x + ship.DeckQuantity; secondShipDeck++)
                            {
                                if(firstShipDeck == secondShipDeck)
                                {
                                    result = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (var firstShipDeck = point.x; firstShipDeck < point.x + deckQuantity; firstShipDeck++)
                        {
                            for (var secondShipDeck = ship.Position.y; secondShipDeck < ship.Position.y + ship.DeckQuantity; secondShipDeck++)
                            {
                                if (firstShipDeck == secondShipDeck)
                                {
                                    result = false;
                                }
                            }
                        }
                    }
                }
            }

            //Check that ship is inside borders
            if(direction == ShipDirection.Vertical)
            {
                if((point.y + deckQuantity - 1) >= boardSize)
                {
                    result = false;
                }
            }
            else
            {
                if((point.x + deckQuantity - 1) >= boardSize)
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
