using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Faction
    {

        protected UnitFactory unitFactory
        {
            get;
            set;
        }
    
       
        protected People people
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Unit[] troops; 


        public  void createArmy(int size)
        {
            troops = new Unit[size];
            for ( int i = 0 ; i < size ; i++)
            {
               troops[i] = this.unitFactory.createUnit();
            } 
        }
    }
}
