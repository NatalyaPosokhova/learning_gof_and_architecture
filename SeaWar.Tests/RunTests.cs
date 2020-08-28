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
    }
}
