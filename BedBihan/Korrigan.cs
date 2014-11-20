using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Korrigan : Unit
    {
        private void setKorriganStandartCostOfMovement()
        {
            costOfMovement[(int) Field.Plain] = 0.5F;
        }
        public Korrigan()
        {
            setKorriganStandartCostOfMovement();
        }
        public Korrigan(int maxLife, int att, int def, int maxMov, Coordinates spawningPoint) : base(maxLife, att, def, maxMov, spawningPoint)
        {
            setKorriganStandartCostOfMovement();
        }

        public override void moveOn(Hexagon hexagon)
        {
            throw new NotImplementedException();
        }
    }
}


