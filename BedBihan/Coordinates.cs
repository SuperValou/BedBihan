using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public struct Coordinates
    {
        public int x, y;
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
                return this.x == coord.x && this.y == coord.y + 1    // left
                        || this.x == coord.x + 1 && this.y == coord.y + 1    // top left
                        || this.x == coord.x + 1 && this.y == coord.y        // top right
                        || this.x == coord.x && this.y == coord.y - 1    // right
                        || this.x == coord.x - 1 && this.y == coord.y        // bottom right
                        || this.x == coord.x - 1 && this.y == coord.y + 1;   // bottom left
            }
            else
            // x is odd
            {
                return this.x == coord.x && this.y == coord.y + 1    // left
                        || this.x == coord.x + 1 && this.y == coord.y        // top left
                        || this.x == coord.x + 1 && this.y == coord.y - 1    // top right
                        || this.x == coord.x && this.y == coord.y - 1    // right
                        || this.x == coord.x - 1 && this.y == coord.y - 1    // bottom right
                        || this.x == coord.x - 1 && this.y == coord.y;      // bottom left;
            }
        }

            /*
         * return the list of coordinates adjacent to these coordinates
         * */
        public List<Coordinates> getAdjacent()
        {
            if (this.x % 2 == 0)
            // x is even
            {
                return    new List<Coordinates>
                {
                    new Coordinates(this.x,this.y + 1),    // left
                    new Coordinates(this.x+1,this.y+1),
                    new Coordinates(this.x+ 1,this.y + 1),    // top left
                    new Coordinates(this.x + 1, this.y),        // top right
                    new Coordinates(this.x, this.y - 1),    // right
                    new Coordinates(this.x - 1,  this.y),        // bottom right
                    new Coordinates(this.x - 1,  this.y + 1)  // bottom left
                };
            }
            else
            // x is odd
            {
                return    new List<Coordinates>
                {
                    new Coordinates(this.x,this.y+ 1),    // left
                    new Coordinates(this.x + 1,this.y),        // top left
                    new Coordinates(this.x + 1,this.y - 1),    // top right
                    new Coordinates(this.x, this.y - 1),    // right
                    new Coordinates(this.x - 1,this.y - 1),    // bottom right
                    new Coordinates(this.x- 1,this.y)      // bottom left;
                };
            }
                        
        }
    }
    
}
