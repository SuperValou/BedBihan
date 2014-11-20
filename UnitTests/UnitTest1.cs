using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedBihan;

namespace UnitTests
{
    [TestClass]
    public class TestGame
    {
        [TestMethod]
        public void TestGetBoard()
        {
            Board board = new Board();
            Game game = new Game(board);
            Assert.AreEqual(board, game.Board);
        }
    }

    [TestClass]
    public class TestUnit
    {
        [TestMethod]
        public void TestCostOfMovement()
        {
            Human coco = new Human();
            float costOnPlain = coco.getCostOfMovementOn(Field.Plain);
            float costOnDesert = coco.getCostOfMovementOn(Field.Desert);
            // Assert.AreEqual(expected value, actual value);
            Assert.AreEqual(0.5F, costOnPlain);
            Assert.AreEqual(1, costOnDesert);
        }
    }


}
