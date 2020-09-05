using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeaWar;

namespace SeaWar.Tests
{
    class GetShipTests
    {
        [Test]
        public void SuccessShipReturnTest()
        {
            var expectedShip = new Ship(new Point { x = 2, y = 3}, 4, ShipDirection.Vertical);
            Board board = new Board();
            board.CreateShip(new Point { x = 2, y = 3 }, 4, ShipDirection.Vertical);
            Assert.AreEqual(board.GetShip(new Point { x = 2, y = 4 }), expectedShip);
        }
    }
}
