using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SeaWar;

namespace SeaWar.Tests
{
    class MakeShootTests
    {
        private Board board;

        [SetUp]
        public void BoardSetUp()
        {
            board = new Board();
        }

        [Test]
        public void SuccessMakeShootHitShipTest()
        {
            board.CreateShip(new Point { x = 4, y = 4 }, 4, ShipDirection.Vertical);
            Assert.IsTrue(board.MakeShoot(new Point { x = 4, y = 4 }));
        }

        [Test]
        public void FailMakeShootHitShipTest()
        {
            board.CreateShip(new Point { x = 5, y = 3 }, 2, ShipDirection.Vertical);
            Assert.IsFalse(board.MakeShoot(new Point { x = 3, y = 3 }));
        }
		
		        [Test]
        public void SuccessShipHorizontalDied()
        {
            board.CreateShip(new Point { x = 3, y = 5 }, 4, ShipDirection.Horizontal);
            board.MakeShoot(new Point { x = 3, y = 5});
            board.MakeShoot(new Point { x = 4, y = 5 });
            board.MakeShoot(new Point { x = 5, y = 5});
            board.MakeShoot(new Point { x = 6, y = 5 });
            Assert.AreEqual(board.GetShipsQuantity(), 0);
        }

        [Test]
        public void SuccessShipVerticalDied()
        {
            board.CreateShip(new Point { x = 2, y = 2 }, 4, ShipDirection.Vertical);
            board.MakeShoot(new Point { x = 2, y = 2 });
            board.MakeShoot(new Point { x = 2, y = 3 });
            board.MakeShoot(new Point { x = 2, y = 4 });
            board.MakeShoot(new Point { x = 2, y = 5 });
            Assert.AreEqual(board.GetShipsQuantity(), 0);
        }

        [Test]
        public void SuccessShipInjured()
        {
            board.CreateShip(new Point { x = 3, y = 6}, 3, ShipDirection.Horizontal);
            board.MakeShoot(new Point { x = 5, y = 6 });

        }
    }
}
