using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedBihan;

namespace UnitTests
{
    /// <summary>
    /// Summary description for CoordinatesTest
    /// </summary>
    [TestClass]
    public class CoordinatesTest
    {
        [TestMethod]
        public void TestAdjacent()
        {
            // it works
            Coordinates centralPoint = new Coordinates(1, 1);
            Console.WriteLine("Central point : "+centralPoint.x+","+centralPoint.y);
            List<Coordinates> adjacents = centralPoint.getAdjacent();
            foreach (Coordinates coord in adjacents)
            {
                Console.WriteLine(coord.x+","+coord.y);
            }

            centralPoint = new Coordinates(2, 2);
            Console.WriteLine("Central point : "+centralPoint.x+","+centralPoint.y);
            adjacents = centralPoint.getAdjacent();
            foreach (Coordinates coord in adjacents)
            {
                Console.WriteLine(coord.x + "," + coord.y);
            }

            centralPoint = new Coordinates(0, 0);
            Console.WriteLine("Central point : " + centralPoint.x + "," + centralPoint.y);
            adjacents = centralPoint.getAdjacent();
            foreach (Coordinates coord in adjacents)
            {
                Console.WriteLine(coord.x + "," + coord.y);
            }

            centralPoint = new Coordinates(0, 4);
            Console.WriteLine("Central point : " + centralPoint.x + "," + centralPoint.y);
            adjacents = centralPoint.getAdjacent();
            foreach (Coordinates coord in adjacents)
            {
                Console.WriteLine(coord.x + "," + coord.y);
            }

            centralPoint = new Coordinates(4, 0);
            Console.WriteLine("Central point : " + centralPoint.x + "," + centralPoint.y);
            adjacents = centralPoint.getAdjacent();
            foreach (Coordinates coord in adjacents)
            {
                Console.WriteLine(coord.x + "," + coord.y);
            }

            centralPoint = new Coordinates(4, 4);
            Console.WriteLine("Central point : " + centralPoint.x + "," + centralPoint.y);
            adjacents = centralPoint.getAdjacent();
            foreach (Coordinates coord in adjacents)
            {
                Console.WriteLine(coord.x + "," + coord.y);
            }
        
        }
    }
}
