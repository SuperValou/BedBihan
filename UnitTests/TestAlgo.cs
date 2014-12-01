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

        [TestMethod]
        public void TestnumberOfConfrontations()
        {
            int nbOfConf = WrapperGate.access.numberOfConfrontations(2,6);
            Console.WriteLine(nbOfConf);
            Assert.IsTrue(nbOfConf >= 2, "The number of confrontations was less than 2.");
            Assert.IsTrue(nbOfConf <= 8, "The number of confrontations was greater than 8.");
        }

        [TestMethod]
        public void TestchancesOfVictory()
        {
            double chancesOfV = WrapperGate.access.chancesOfVictory(3,4);
            Console.WriteLine(chancesOfV);
            Assert.IsTrue(chancesOfV >= 0, "The chance of victory was less than 0.");
            Assert.IsTrue(chancesOfV < 1, "The chances of victory was greater than 1.");
        }


    }
}
