﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Plain : Hexagon
    {
        public override Field field
        {
            get { return Field.Plain; }
        }
    }
}
