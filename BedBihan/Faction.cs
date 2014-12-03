using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Faction
    {

        public Faction(int size, string people)
        {
            switch (people)
            {
                case "korrigan":
                    this.unitFactory = new UnitFactoryKorrigan();
                    break;
                case "human":
                    this.unitFactory = new UnitFactoryHuman();
                    break;
                case "Elf":
                    this.unitFactory = new UnitFactoryElf();
                    break;
            }
            this.createArmy(size);
        }

        protected UnitFactory unitFactory
        {
            get;
            set;
        }




        // tab of units
        public Unit[] troops; 


        private  void createArmy(int size)
        {
            troops = new Unit[size];
            for ( int i = 0 ; i < size ; i++)
            {
               troops[i] = this.unitFactory.createUnit();
            } 
        }
    }
}
