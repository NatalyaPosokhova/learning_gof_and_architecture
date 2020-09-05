using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class Computer : Player
    {
        private List<Point> positionList = new List<Point>();
        private Random random;
        public Computer(string name) : base(name)
        {
            random = new Random();
        }

        public override Point GetShoot()
        {
            Point pt = new Point();
            do
            {
                pt.x = random.Next(1, 9);
                pt.y = random.Next(1, 9);
            } while (positionList.Contains(pt));

            positionList.Add(pt);
            return pt;
        }
    }
}
