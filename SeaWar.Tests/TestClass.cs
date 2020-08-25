// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SeaWar;

namespace SeaWar.Tests
{
    [TestFixture]
    public class CreateShipTests
    {
        [Test]
        public void CreateShipExceptionTest()
        {
            Board board = new Board();
            Assert.Throws<CreateShipException>(() => board.CreateShip(new Point { x = 12, y = 4 }, 2, ShipDirection.Horizontal));
        }

        [Test]
        public void SuccessShipCreateTest()
        {
            Board board = new Board();
            board.CreateShip(new Point { x = 4, y = 4 }, 4, ShipDirection.Vertical);

        }
    }
}
