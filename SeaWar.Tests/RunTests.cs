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
    public class RunTests
    {
        private GameLogic logic;
        private Computer player1;
        private Computer player2;
        private Board board1;
        private Board board2;
        private List<Player> PlayersList;
        private List<Board> BoardsList;


        [SetUp]
        public void GameLogicSetUp()
        {
            player1 = new Computer("Computer1");
            player2 = new Computer("Computer2");
            board1 = new Board();
            board2 = new Board();
            PlayersList = new List<Player> { player1, player2 };
            BoardsList = new List<Board> { board1, board2 };
            logic = new GameLogic(PlayersList, BoardsList);
        }

        [Test]
        public void CreateShipExceptionLotsBordersTest()
        {
            BoardsList.Add(new Board());
            Assert.Throws<CreateShipException>(() => logic.Run());
        }

        [Test]
        public void CreateShipExceptionLotsPlayersTest()
        {
            PlayersList.Add(new Computer("Computer3"));
            Assert.Throws<CreateShipException>(() => logic.Run());
        }
        [Test]
        public void SuccessRunTest()
        {
            board1.CreateShip(new Point { x = 1, y = 2}, 4, ShipDirection.Horizontal);
            board2.CreateShip(new Point { x = 3, y = 4 }, 3, ShipDirection.Vertical);

            Assert.AreEqual(board1.GetShipsQuantity(), 1);
            Assert.AreEqual(board2.GetShipsQuantity(), 1);

            //logic.Run();
            //Assert.IsFalse(board1.IsAllShipsDied());
            //Assert.IsFalse(board2.IsAllShipsDied());
        }
    }
}
