using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Board
    {
        public Hexagon[,] grid
        {
            get;
            set;
        }

        

        public int b_size
        {
            get;
            set;
        }
        

        public StrategyBoard strategy
        {
            get;
            set;
        }


        public Board(StrategyBoard sb)
        {
            strategy = sb;
        }

        public void BuildBoard()
        {
            grid = strategy.LaunchStrategy();
            b_size = strategy.getSize();
        }

   
    }
}
