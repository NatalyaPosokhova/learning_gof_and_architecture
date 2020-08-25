using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class Computer : Player
    {
        Random random;
        public Computer(string name) : base(name)
        {
            random = new Random();
        }

        public override Point GetShoot()
        {
            Point pt = new Point();
            pt.x = random.Next(1, 9);
            pt.y = random.Next(1, 9);

            return pt;
        }
    }
}
