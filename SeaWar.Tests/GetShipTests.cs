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

        [Test]
        public void EmptyPositionTest()
        {
            Board board = new Board();
            Assert.Throws<ArgumentOutOfRangeException>(()=> board.GetShip(new Point { x = 2, y = 3}));
        }

        [Test]
        public void OneShipMissPositionHorizontalTest()
        {
            Board board = new Board();
            board.CreateShip(new Point { x = 5, y = 6 }, 3, ShipDirection.Horizontal);
            Assert.Throws<ArgumentOutOfRangeException>(()=>board.GetShip(new Point { x = 2, y = 3}));
        }

        [Test]
        public void OneShipMissPositionVerticalTest()
        {
            Board board = new Board();
            board.CreateShip(new Point { x = 5, y = 6 }, 3, ShipDirection.Vertical);
            Assert.Throws<ArgumentOutOfRangeException>(() => board.GetShip(new Point { x = 2, y = 3 }));
        }




    }
}
