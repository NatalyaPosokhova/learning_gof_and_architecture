using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaWar;

namespace SeaWar.Tests
{
    [TestFixture]
    public class ComputerGetShootTests
    {
        [Test]
        public void SuccessGetShootReturnNotNullTest()
        {
            var computer = new Computer("Computer1");
            Assert.IsNotNull(computer.GetShoot());
        }
    }
}
