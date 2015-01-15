using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Game
    {

        public Game() 
        {
            this.currentTurn = 0;        
        }



        public Board board
        {
            get;
            protected set;
        }

        public int maxTurnNumber
        {
            get;
            private set;
        }

        private int currentTurn
        {
            get;
            set;
        }

        public List<Player> list_players
        {
            get;
            set;
        }

        

        public int unitSelected
        {
            get;
            set;
        }

        public void setBoard(Board b) { this.board = b;  }
        public void setMaxTurnNumber(int mtn) { this.maxTurnNumber = mtn; }
       // public void setCurrentTurn(int ct) { this.currentTurn = ct; }
        public void setListplayers(List<Player> lplay) { this.list_players = lplay;  }



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
            this.board = board;
        }

    }
}
