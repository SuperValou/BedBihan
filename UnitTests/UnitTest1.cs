using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedBihan;

namespace UnitTests
{
    [TestClass]
    public class TestGame
    {
     /*   [TestMethod]
        public void TestGetBoard()
        {
            StrategyBoard sb = new StrategyBoardClassic();
            Board board = new Board(sb);
            Game game = new Game(board);
            Assert.AreEqual(board, game.board);
        }*/
    }

    [TestClass]
    public class TestUnit
    {
        [TestMethod]
        public void TestCostOfMovement()
        {
            Human coco = new Human();
            Elf pm = new Elf(1, 2, 3, 1, new Coordinates(0, 0));
            Korrigan hoel = new Korrigan();
            float costOnPlain = coco.getCostOfMovementOn(Field.Plain);
            float costOnDesert = coco.getCostOfMovementOn(Field.Desert);
            // Assert.AreEqual(expected value, actual value);
            Assert.AreEqual(0.5F, costOnPlain);
            Assert.AreEqual(1, costOnDesert);
            costOnPlain = hoel.getCostOfMovementOn(Field.Plain);
            costOnDesert = hoel.getCostOfMovementOn(Field.Desert);
            Assert.AreEqual(0.5F, costOnPlain);
            Assert.AreEqual(1, costOnDesert);
            costOnPlain = pm.getCostOfMovementOn(Field.Woods);
            costOnDesert = pm.getCostOfMovementOn(Field.Desert);
            Assert.AreEqual(0.5F, costOnPlain);
            Assert.AreEqual(2F, costOnDesert);
        }
    }


}