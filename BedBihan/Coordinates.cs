using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BedBihan;

namespace BedBihan
{
    public struct Coordinates
    {
        public static int mapSize = 5; // default value for tests
                    
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
            List<Coordinates> adjacentHexagons = this.getAdjacent();
            foreach (Coordinates adj in adjacentHexagons)
            {
                if (adj.x == coord.x && adj.y == coord.y)
                {
                    return true;
                }
            }
            return false;
        }

        /*
         * \brief return the list of coordinates adjacent to these coordinates
         * */
        public List<Coordinates> getAdjacent()
        {
            List<Coordinates> adjacentHexagons = new List<Coordinates>();

            adjacentHexagons.Add(new Coordinates(this.x-1,   this.y));    // left
            adjacentHexagons.Add(new Coordinates(this.x+1,   this.y));    // right
            adjacentHexagons.Add(new Coordinates(this.x,     this.y+1));  // bottom right if y is even, bottom left if y is odd
            adjacentHexagons.Add(new Coordinates(this.x,     this.y-1));  // top right if y is even, top left if y is odd


            if (this.y % 2 == 0)
            // x is even
            {
                adjacentHexagons.Add(new Coordinates(this.x-1,   this.y-1));    // top left  
                adjacentHexagons.Add(new Coordinates(this.x-1,   this.y+1));    // bottom left
            }
            else
            // x is odd
            {
                adjacentHexagons.Add(new Coordinates(this.x + 1, this.y - 1));  // top right
                adjacentHexagons.Add(new Coordinates(this.x+1,   this.y+1));    // bottom right
            }
            
            //// delete unauthorized coordinates
            //// ugly code
            //List<Coordinates> toDelete = new List<Coordinates>();
            //foreach(Coordinates coord in adjacentHexagons)
            //{
            //    if (coord.x < 0 || coord.x >= mapSize || coord.y < 0 || coord.y >= mapSize)
            //    {
            //        toDelete.Add(coord);
            //    }
            //}
            //foreach (Coordinates coord in toDelete)
            //{
            //    adjacentHexagons.Remove(coord);
            //}

            return adjacentHexagons;
        }
    }
    
}
