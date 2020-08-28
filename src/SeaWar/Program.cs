using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            currentShip ship = new currentShip(new Point { x = 4, y = 4 }, 2, ShipDirection.Horizontal);
            ship.CheckShooting(new Point { x = 5, y = 4 });
            Console.Write("test");
            Console.ReadKey();

        }
    }
}
