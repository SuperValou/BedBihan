using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class KorriganFaction : AbstractFaction
    {

        public KorriganFaction(int size) : base (size)
        {
            this.unitFactory = new UnitFactoryKorrigan();
            this.createArmy(size); 
        }

    }
}