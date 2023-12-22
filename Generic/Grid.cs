using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedRayLibGrid.Generic
{
    internal class Grid
    {
        //number of lines and rows
        public int lines;
        public int rows;

        public Grid(int lines, int rows)
        {
            this.lines = lines;
            this.rows = rows;
        }
    }
}
