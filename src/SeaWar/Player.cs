using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public abstract class Player
    {
        public string Name { get; private set; }
        public Player(string name)
        {
            this.Name = name;
        }
        public abstract bool MakeShoot(Point point);       
    }
}
