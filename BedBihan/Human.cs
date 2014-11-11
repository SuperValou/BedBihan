using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Human : Unit
    {
        public int killsNb
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public override int getCostOfMovementOn(Field field)
        {
            throw new NotImplementedException();
        }
    }
}
