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
        /// <summary>
        /// Sets order of play
        /// </summary>
        public void Run()
        {
            if (_boards.Count() != 2 || _players.Count() != 2)
            {
                throw new CreateShipException("Quantity of Boards and Players should be equal 2");
            }
            while (!_boards[0].IsAllShipsDied() || !_boards[1].IsAllShipsDied())
            {
                _boards.ForEach(el => el.OnShootHappend += El_OnShootHappend);

                var shootCoord = _players[0].GetShoot();
                _boards[1].MakeShoot(shootCoord);

                shootCoord = _players[1].GetShoot();
                _boards[0].MakeShoot(shootCoord);
            }
        }

        private void El_OnShootHappend(object sender, ModelEventArgs e)
        {
            Console.WriteLine(e.shootStatus);
        }
    }
}
