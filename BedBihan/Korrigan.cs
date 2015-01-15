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
        public Korrigan() : base()
        {
            setKorriganStandartCostOfMovement();
            faction = Faction.korrigan;
        }


        public Korrigan(int maxLife, int att, int def, int maxMov, Coordinates spawningPoint) : base(maxLife, att, def, maxMov, spawningPoint)
        {
            setKorriganStandartCostOfMovement();
            faction = Faction.korrigan;
        }

        /*
         * \brief return number of points got
         * */
        public override int getPoints()
        {
            throw new NotImplementedException();
        }
       
    }
}


