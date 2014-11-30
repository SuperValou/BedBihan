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
            Korrigan coco = new Korrigan(10,3,2,1,new Coordinates(0,0));
            Elf valou = new Elf(10,3,2,1,new Coordinates(0,0));
            coco.fightAgainst(valou);
            Console.WriteLine(coco.currentHP + " "+valou.currentHP);
            Assert.IsTrue(coco.isDead() || valou.isDead(), "Someone survived.");
            Assert.IsTrue(false, "I will finish this :) ");
        }
    }
}
