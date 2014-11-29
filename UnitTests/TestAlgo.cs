using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedBihan;

namespace UnitTests
{
    [TestClass]
    public class TestAlgo
    {
        [TestMethod]
        public unsafe void TestMapGeneratorAlgo()
        {
            int** map = WrapperGate.access.mapGenerator(4);

            int nb_zero = 0;
            int nb_un = 0;
            int nb_deux = 0;
            int nb_trois = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (map[i][j])
                    {
                        case 0:
                            nb_zero++;
                            break;
                        case 1:
                            nb_un++;
                            break;
                        case 2:
                            nb_deux++;
                            break;
                        case 3:
                            nb_trois++;
                            break;
                        default:
                            break;
                    }
                }
            }

            Assert.AreEqual(4, nb_un);
            Assert.AreEqual(4, nb_deux);
            Assert.AreEqual(4, nb_trois);
            Assert.AreEqual(4, nb_zero);
            
        }

        [TestMethod]
        public unsafe void TestMapGenerator()
        {
            StrategyBoardDemo sbd = new StrategyBoardDemo();
            Board gameBoard = new Board(sbd);
            gameBoard.BuildBoard();
            Hexagon current_hex;

            int[] test_nb_of_world = new int[4];

            for (int i = 0; i < 4; i++) // TODO : fix size of board access problem
            {
                for (int j = 0; j < 4; j++)
                {
                    current_hex = gameBoard.grid[i,j];
                    test_nb_of_world[(int)current_hex.field]++;
                }
            }

            for (int i = 0; i < 4; i++) // TODO : fix size of board access problem
            {

                Assert.AreEqual(test_nb_of_world[i], 4);
               
            }

        }
    }
}
