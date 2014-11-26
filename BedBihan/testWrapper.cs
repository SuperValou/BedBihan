using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wrapper;

namespace BedBihan
{
    public class testWrapper
    {
        public int go(int x)
        {
            WrapperAlgo w = new WrapperAlgo();
            return w.computeFoo(x);
         }
    }
}
