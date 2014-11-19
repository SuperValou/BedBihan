using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Mountain : Hexagon
    {
        public override Field field
        {
            get { return Field.Mountain; }
        }
    }
}
