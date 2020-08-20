using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class GameLogic
    {
        private List<Player> _players;
        private List<Board> _boards;
        public GameLogic(List<Player> Players, List<Board> Boards)
        {
            _players = Players;
            _boards = Boards;
        }
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
