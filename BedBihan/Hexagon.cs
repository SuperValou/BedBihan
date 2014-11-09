using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class HexagonTexture
    {

    }

    public class Hexagon
    {
        public HexagonTexture texture
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Field fieldType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public System.Collections.Generic.IEnumerable<Unit> listOfUnits
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Coordinates coordinates
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void calculatePoints()
        {
            throw new System.NotImplementedException();
        }

        public Unit selectBestUnit()
        {
            throw new System.NotImplementedException();
        }
    }
}
