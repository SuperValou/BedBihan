using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Human : Unit
    {
        public int numberOfKills
        {
            get;
            private set;
        }

        public void addKill()
        {
            this.numberOfKills++;
        }
  
        private void setHumanStandartCostOfMovement()
        {
            this.costOfMovement[(int)Field.Plain] = 0.5F;
        }
        

        public Human() : base()
        {
            setHumanStandartCostOfMovement();
            faction = Faction.human;
        }

        public Human(int maxLife, int att, int def, int maxMov, Coordinates spawningPoint) : base(maxLife, att, def, maxMov, spawningPoint)
        {
            setHumanStandartCostOfMovement();
            faction = Faction.human;
        }

        /*
         * \brief return number of points got
         * */
        public override int getPoints()
        {
            return 1 + numberOfKills;
        }




       
    }
}
