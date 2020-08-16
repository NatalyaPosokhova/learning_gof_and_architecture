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
    }
}
