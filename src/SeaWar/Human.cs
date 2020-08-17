using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class Human : Player
    {
        public Human(string name) : base(name)
        {
        }

        public override bool MakeShoot(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
