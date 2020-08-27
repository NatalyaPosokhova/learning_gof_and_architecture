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
        private List<Player> Players;
        private List<Board> Boards;


        [SetUp]
        public void GameLogicSetUp()
        {
            player1 = new Computer("Computer1");
            player2 = new Computer("Computer2");
            board1 = new Board();
            board2 = new Board();
            Players = new List<Player> { player1, player2 };
            Boards = new List<Board> { board1, board2 };
            logic = new GameLogic(Players, Boards);
        }

        [Test]
        public void CreateShopExceptionLotsBordersTest()
        {
            Boards.Add(new Board());
            Assert.Throws<CreateShipException>(() => logic.Run());
        }

        [Test]
        public void CreateShopExceptionLotsPlayersTest()
        {
            Players.Add(new Computer("Computer3"));
            Assert.Throws<CreateShipException>(() => logic.Run());
        }
    }
}
