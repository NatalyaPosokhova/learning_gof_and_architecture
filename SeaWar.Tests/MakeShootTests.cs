using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SeaWar;
using System.Reflection;

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
        public void MakeShootHitShipTest()
        {
            board.CreateShip(new Point { x = 4, y = 4 }, 4, ShipDirection.Vertical);
            Assert.IsTrue(board.MakeShoot(new Point { x = 4, y = 4 }));
        }       
    }
}
