using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SeaWar;
using System.Reflection;

namespace SeaWar.Tests
{
    class CheckShootingTests
    {

        [Test]
        public void SuccessShipHitTest()
        {
            currentShip ship = new currentShip(new Point { x = 4, y = 4 }, 1, ShipDirection.Vertical);

            Assert.AreEqual(ship.CheckShooting(new Point { x = 4, y = 4 }), true);
            Assert.That(ship.State == ShipState.Died);
        }

        [Test]
        public void CheckThatShipInjuredTest()
        {
            currentShip ship = new currentShip(new Point { x = 4, y = 4 }, 2, ShipDirection.Horizontal);
            ship.CheckShooting(new Point { x = 5, y = 4 });
            Assert.That(ship.State == ShipState.Injured);
        }
    }
}
