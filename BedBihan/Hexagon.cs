using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Hexagon
    {
        public int field  // plutot un enum que des int ?
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
            return units.Length == 0;
        }

        // return the color of the units on this hexagon
        public int color()
        {
            return units[0].color;
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
