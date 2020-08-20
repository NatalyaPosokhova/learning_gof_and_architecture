using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class Computer : Player
    {
        public Computer(string name) : base(name)
        {

        }

        public override Point GetShoot()
        {
            throw new NotImplementedException();
        }
    }
}
