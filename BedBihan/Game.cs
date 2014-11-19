using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Game
    {
        public Board Board
        {
            get;
            private set;
        }

        public int MaxTurnNumber
        {
            get;
            private set;
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

        public IEnumerable<Player> Players
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int unitSelected
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

        public void endGame()
        {
            throw new System.NotImplementedException();
        }

        public void launchTurn()
        {
            throw new System.NotImplementedException();
        }

        public void updatePlayerPoints(Player player)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Unit> getUnitsOn(Coordinates coord)
        {
            throw new System.NotImplementedException();
        }



        public Game(global::BedBihan.Board board)
        {
            // TODO: Complete member initialization
            this.Board = board;
        }

    }
}
