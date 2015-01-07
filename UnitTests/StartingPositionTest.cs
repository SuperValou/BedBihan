using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedBihan;

namespace UnitTests
{
    [TestClass]
    public class StartingPositionTest
    {
        [TestMethod]
        public unsafe void testStartingPosition()
        {
            int** positions;
            int size = 16; // map size
            positions = WrapperGate.access.getStartingPositions(8, size);
            for (int i = 0; i<8 ; i++)
            {
                Console.WriteLine(positions[i][0] + " - " + positions[i][1]);
            }
           
        }
    }
}
