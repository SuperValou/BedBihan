﻿using System;
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
            faction = Faction.elf;
        }
        public Elf(int maxLife, int att, int def, int maxMov, Coordinates spawningPoint) : base(maxLife, att, def, maxMov, spawningPoint)
        {
            this.movementPoints = maxMov;
            setElfStandartCostOfMovement();
            faction = Faction.elf;
        }

        /*
         * \brief return number of points got
         * */
        public override int getPoints(Field f)
        {
            if (currentHP <= 0) { return 0; }
            return 1;
        }
        
    }
}
