using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    /// <summary>
    /// Board for ships
    /// </summary>
    public abstract class Board
    {
        /// <summary>
        /// Board size
        /// </summary>
        protected const int size = 10;
        /// <summary>
        /// Determine name of every cell
        /// </summary>
        protected char[] verticalNumeration = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};
        protected int[] horisontalNumeration = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }
}
