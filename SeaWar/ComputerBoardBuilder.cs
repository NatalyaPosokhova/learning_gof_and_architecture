using System;
using System.Collections.Generic;
using System.Text;

namespace SeaWar
{
    class ComputerBoardBuilder : BoardBuilder
    {
        public override Board GetBoard()
        {
            Board board = new Board();
            board.CreateShip(new Point { x = 1, y = 5}, 4, ShipDirection.Horizontal);
            board.CreateShip(new Point { x = 6, y = 1 }, 3, ShipDirection.Vertical);
            board.CreateShip(new Point { x = 3, y = 3 }, 1, ShipDirection.Horizontal);
            return board;
        }
    }
}
