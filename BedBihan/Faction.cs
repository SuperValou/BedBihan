﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Faction
    {
        public People people
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IEnumerable<Unit> troops
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
