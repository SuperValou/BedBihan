using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Player
    {
        public Colour colour
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IEnumerable<Unit> points
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Faction faction
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void playTurn()
        {
            /*
             * for each unit
             * move
             */
        }

        public void updatePoint()
        {
            /*
             * res = 0;
             * for each unit u {
             *     res += u.generatePoint
             *     }
             */     
        }


    }
}
