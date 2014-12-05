using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class StrategyBoard
    {
        protected HexagonFactory hexFactory;
        protected int size;

      
        public unsafe Hexagon[,] LaunchStrategy()
        {
            hexFactory = new HexagonFactory();


            int** mapInt; // IMPORTANT ! INSTANCE MEMORY BEFORE ACCESS WRAPPER !
                           // ONE FUCKING HOUR LOST FOR THIS SHIT
            mapInt = WrapperGate.access.mapGenerator(size);
            Hexagon[,] map = new Hexagon[size, size];

            for (int i = 0; i < size; i++)
             {
                for(int j =0; j < size; j++)
                {
                    switch(mapInt[i][j]){
                        case (int) Field.Desert:
                            map[i,j] = hexFactory.getHexagons("Desert");
                            break;
                        case (int) Field.Mountain:
                            map[i,j] = hexFactory.getHexagons("Mountain");
                            break;
                        case (int) Field.Plain:
                            map[i,j] = hexFactory.getHexagons("Plain");
                            break;
                        case (int) Field.Woods:
                            map[i,j] = hexFactory.getHexagons("Woods");
                            break;
                        default:
                            map[i,j] = hexFactory.getHexagons("Woods");
                            break;
                    }
                }
            }
            return map;
        }



    }
}
