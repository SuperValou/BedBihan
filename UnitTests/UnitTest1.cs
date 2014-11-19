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
            int costOnPlain = coco.getCostOfMovementOn(Field.Plain);
            Assert.Equals(1, costOnPlain);
        }
    }


}
