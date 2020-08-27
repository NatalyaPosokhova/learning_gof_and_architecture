// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SeaWar;
using System.Reflection;

[assembly: AssemblyVersionAttribute("4.3.2.1")]

namespace SeaWar.Tests
{
    [TestFixture]
    public class CreateShipTests
    {
        private Board board;
        [SetUp]
        public void boardCreationSetUp()
        {
            board = new Board();
        }

        [Test]
        public void CreateShipExceptionTest()
        {
            
            Assert.Throws<CreateShipException>(() => board.CreateShip(new Point { x = 12, y = 4 }, 2, ShipDirection.Horizontal));
        }

        [Test]
        public void SuccessShipCreateTest()
        {
            Board board = new Board();
            board.CreateShip(new Point { x = 4, y = 4 }, 4, ShipDirection.Vertical);
        }

        [Test]
    }
}
