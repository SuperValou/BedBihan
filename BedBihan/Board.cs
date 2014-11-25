using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Board
    {
        protected Hexagon[,] grid;
        
        public StrategyBoard strategy
        {
            get;
            set;
        }

        public void BuildBoard()
        {
            grid = strategy.LaunchStrategy();
        }

   
    }
}
