using System;
using System.Collections.Generic;
using System.Text;

namespace SeaWar
{
    class HumanBoardBuilder : BoardBuilder
    {
        private Board board;
        public HumanBoardBuilder()
        {
            board = new Board();
        }
        public override Board GetBoard()
        {
            return board;
        }

        internal void Add(Point point, int deckQuantity, ShipDirection direction)
        {
            board.CreateShip(point, deckQuantity, direction);
        }
    }
}
