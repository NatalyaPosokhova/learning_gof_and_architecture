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
        private Board board;

        [SetUp]
        public void BoardCreationSetUp()
        {
            board = new Board();
        }

        [Test]
        public void CreateShipExceptionOutBordersTest()
        {
            Assert.Throws<CreateShipException>(() => board.CreateShip(new Point { x = 12, y = 4 }, 2, ShipDirection.Horizontal));
        }

        [Test]
        public void SuccessShipCreateTest()
        {
            board.CreateShip(new Point { x = 4, y = 4 }, 4, ShipDirection.Vertical);
        }

        [Test]
        public void CreateShipExceptionCrossAnotherShipTest()
        {
            board.CreateShip(new Point { x = 5, y = 2 }, 2, ShipDirection.Vertical);
            Assert.Throws<CreateShipException>(() => board.CreateShip(new Point { x = 5, y = 2 }, 2, ShipDirection.Vertical));
        }

        [Test]
        public void TwoShipsAlongsideEachOtherHorizontalTest()
        {
            board.CreateShip(new Point { x = 1, y = 3 }, 3, ShipDirection.Horizontal);
            Assert.Throws<CreateShipException>(() => board.CreateShip(new Point { x = 2, y = 2 }, 3, ShipDirection.Horizontal));
        }

        [Test]
        public void TwoShipsAlongsideEachOtherVerticalTest()
        {
            board.CreateShip(new Point { x = 1, y = 1 }, 4, ShipDirection.Vertical);
            Assert.Throws<CreateShipException>(() => board.CreateShip(new Point { x = 2, y = 3}, 3, ShipDirection.Vertical));
        }

        [Test]
        public void SingleTwoShipsTest()
        {
            board.CreateShip(new Point { x = 1, y = 1 }, 1, ShipDirection.Horizontal);
            board.CreateShip(new Point { x = 3, y = 4 }, 1, ShipDirection.Horizontal);
        }
    }
}
