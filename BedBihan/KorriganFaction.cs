using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class KorriganFaction : Faction
    {

        public KorriganFaction()
        {
            this.unitFactory = new UnitFactoryKorrigan();
        }

    }
}
