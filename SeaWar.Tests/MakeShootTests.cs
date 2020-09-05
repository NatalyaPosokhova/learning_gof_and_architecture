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
    }
}
