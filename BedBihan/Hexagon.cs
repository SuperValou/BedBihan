using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Hexagon
    {
        public Field field
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        // units on this hexagon
        public Unit[] units
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


        public bool isFree()
        {
            return this.units.Length ==0 ;
        }


        public Unit selectBestUnit()
        {
            Unit bestUnit = this.units[0];
            for (int i = 1; i < this.units.Length; i++)
            {
                if (this.units[i].defense > bestUnit.defense)
                {
                    bestUnit = this.units[i];
                }
            }       
            return bestUnit;
       }

        // TO DO add unit
        public void addUnit(Unit unit)
        {
           
        }
    }
}
