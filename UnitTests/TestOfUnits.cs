using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedBihan;

namespace UnitTests
{
    [TestClass]
    public class TestOfUnits
    {
        [TestMethod]
        public void TestfightAgainst()
        {
            Korrigan coco = new Korrigan(100,5,10,1,new Coordinates(0,0));
            Elf valou = new Elf(100,10,5,1,new Coordinates(0,0));
            coco.fightAgainst(valou);
            Console.WriteLine(coco.currentHP + " "+valou.currentHP);
            Assert.IsTrue(coco.currentHP < coco.maxHP || valou.currentHP < valou.maxHP, "Nobody gets hurt.");
        }
    }
}
