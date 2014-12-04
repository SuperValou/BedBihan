using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedBihan;

namespace UnitTests
{
    [TestClass]
    public class UnitTestFactoryUnit
    {
        [TestMethod]
        public void TestKorriganFabrication()
        {
            Player pKorrigan = new Player(5, "korrigan");
            for (int i = 0; i<5; i++)

            {
                Assert.IsInstanceOfType( pKorrigan.faction.troops[i] , typeof(Korrigan) );
            }
        
        }

        [TestMethod]
        public void TestHumanFabrication()
        {
            Player pHuman = new Player(5, "human");
            for (int i = 0; i < 5; i++)
            {
                Assert.IsInstanceOfType(pHuman.faction.troops[i], typeof(Human));
            }

        }

        [TestMethod]
        public void TestElfFabrication()
        {
            Player pElf = new Player(5, "elf");
           
            for (int i = 0; i < 5; i++)
            {
                Assert.IsInstanceOfType(pElf.faction.troops[i], typeof(Elf));
            }

        }
    }
}
