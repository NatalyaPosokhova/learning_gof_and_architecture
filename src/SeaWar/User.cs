using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class User
    {
        /// <summary>
        /// Sets User Name
        /// </summary>
        public string Name { get; private set; }
        public User(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Allows User to shoot on the Rival's board
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public string MakeShoot(Point point)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Allows place sheep on the user's board
        /// </summary>
        /// <param name="ship"></param>
        public void PlaceSheep(Ship ship)
        {
            throw new NotImplementedException();
        }
    }
}
