using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedBihan;

namespace UnitTests
{
    [TestClass]
    public class TestBuilder
    {
        [TestMethod]
        public unsafe void TestDemoBuilder()
        {
            GameCreator gc = new GameCreator();
            gc.setPeopleJ1("elf");
            gc.setPeopleJ2("human");
            GameBuilder gb = new DemoGameBuilder();
            gc.gameBuilder = gb;
            gc.createGame();
            Game game = gc.getGame();
            Assert.AreEqual(game.maxTurnNumber, 5);
        }
    }
}
