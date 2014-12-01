using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Elf : Unit
    {
        private void setElfStandartCostOfMovement()
        {
            costOfMovement[(int) Field.Woods] = 0.5F;
            costOfMovement[(int) Field.Desert] = 2F;
        }
        public Elf() : base()
        {
            setElfStandartCostOfMovement();
        }
        public Elf(int maxLife, int att, int def, int maxMov, Coordinates spawningPoint) : base(maxLife, att, def, maxMov, spawningPoint)
        {
            setElfStandartCostOfMovement();
        }

        
    }
}
