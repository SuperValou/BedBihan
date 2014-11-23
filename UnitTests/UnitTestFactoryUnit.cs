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
            Faction army = new KorriganFaction();
            army.createArmy(5);
            for (int i = 0; i<5; i++)

            {
                Assert.IsInstanceOfType( army.troops[i] , typeof(Korrigan) );
            }
           
        }

        [TestMethod]
        public void TestHumanFabrication()
        {
            Faction army = new HumanFaction();
            army.createArmy(5);
            for (int i = 0; i < 5; i++)
            {
                Assert.IsInstanceOfType(army.troops[i], typeof(Human));
            }

        }

        [TestMethod]
        public void TestElfFabrication()
        {
            Faction army = new ElfFaction();
            army.createArmy(5);
            for (int i = 0; i < 5; i++)
            {
                Assert.IsInstanceOfType(army.troops[i], typeof(Elf));
            }

        }
    }
}
