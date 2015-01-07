using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class AbstractFaction
    {

        public AbstractFaction(int size)
        {
          // this.createArmy(size);  pb with order. (heritage)
        }

        protected UnitFactory unitFactory
        {
            get;
            set;
        }




        // tab of units
        public Unit[] troops; 


        protected  void createArmy(int size)
        {
            troops = new Unit[size];
            for ( int i = 0 ; i < size ; i++)
            {
               troops[i] = this.unitFactory.createUnit();
            } 
        }
    }
}
