﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class ElfFaction : AbstractFaction
    {
        public ElfFaction(int size) : base (size)
        {
            this.unitFactory = new UnitFactoryElf();
            this.createArmy(size);
        }
    }
}
