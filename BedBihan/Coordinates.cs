using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public struct Coordinates
    {
        int x, y;
        public Coordinates(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        /*
         * return true if the coordinates are adjacent to the current coordinates (hexagonal grid)
         * */
        public bool isAdjacentTo(Coordinates coord)
        {
            if (this.x % 2 == 0)
            // x is even
            {
                return     this.x == coord.x        && this.y == coord.y + 1    // left
                        || this.x == coord.x + 1    && this.y == coord.y + 1    // top left
                        || this.x == coord.x + 1    && this.y == coord.y        // top right
                        || this.x == coord.x        && this.y == coord.y - 1    // right
                        || this.x == coord.x - 1    && this.y == coord.y        // bottom right
                        || this.x == coord.x - 1    && this.y == coord.y + 1;   // bottom left
            }
            else
            // x is odd
            {
                return     this.x == coord.x        && this.y == coord.y + 1    // left
                        || this.x == coord.x + 1    && this.y == coord.y        // top left
                        || this.x == coord.x + 1    && this.y == coord.y - 1    // top right
                        || this.x == coord.x        && this.y == coord.y - 1    // right
                        || this.x == coord.x - 1    && this.y == coord.y - 1    // bottom right
                        || this.x == coord.x - 1    && this.y == coord.y ;      // bottom left;
            }
                        
        }
    }
    
}
