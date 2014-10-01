using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Unit
    {

        public int healthPoint
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int movementPoint
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int[] movementCoeffs
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void move()
        {
            throw new System.NotImplementedException();
        }
    }
}
