﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Desert : Hexagon
    {
        public override Field field
        {
            get { return Field.Desert; }
        }
    }
}
