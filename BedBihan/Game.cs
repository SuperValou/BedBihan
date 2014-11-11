using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public static class Game
    {
        public Board board
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int MaxTurnNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int CurrentTurn
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static IEnumerable<Player> Players
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static int unitSelected
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static int Property
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void endTurn()
        {
            /*
             * Compter les points
             *
             */
        }

        public void launchGame()
        {
            /*
             * while(nbTour == nbTourmax || UnseulJoueurLeft() )
             *    for each (List.joueur.play j)
             *      j.playturn();
             *      j alive ? 
             *     }
             *   for each (List.joueur.play j){
             *     Update j.point
             *   }
             *    game.nextTurn();
             * }      
             *    
             */
        }

        public static void endGame()
        {
            throw new System.NotImplementedException();
        }

        public static void launchTurn()
        {
            throw new System.NotImplementedException();
        }

        public static void updatePlayerPoints(Player player)
        {
            throw new System.NotImplementedException();
        }

        public static IEnumerable<Unit> getUnitsOn(Coordinates coord)
        {
            throw new System.NotImplementedException();
        }


        // changer



    }
}
