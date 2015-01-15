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
            Elf pm = new Elf(1, 2, 3, 1, new Coordinates(0, 0));
            pm.looseMovementPoints(Field.Woods);
            Assert.AreEqual(0.5F, pm.movementPoints);
        }
    }


}