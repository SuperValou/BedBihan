using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class UnitFactoryElf : UnitFactory
    {
        public override Unit createUnit()
        {
            return new Elf();
        }
    }

    public class UnitFactoryKorrigan : UnitFactory
    {
        public override Unit createUnit()
        {
            return new Korrigan();
        }
    }

    public class UnitFactoryHuman : UnitFactory
    {
        public override Unit createUnit()
        {
            return new Human();
        }
    }
}
