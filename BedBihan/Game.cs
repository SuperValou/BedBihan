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

        public Player currentPlayer
        {
            get;
            set;
        }

        public int maxTurnNumber
        {
            get;
            private set;
        }

        public int currentTurn
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
        public void setMaxTurnNumber(int mtn) 
        { 
            this.maxTurnNumber = mtn;
            this.currentTurn = 1;
        }

        public void setListplayers(List<Player> lplay) 
        {
            this.list_players = lplay;
            this.currentPlayer = lplay.First<Player>();
        }



        public void endTurn()
        {
            foreach (Player p in list_players)
            {
                p.restorePoint();
            }
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



        public IEnumerable<Unit> getUnitsOn(Coordinates coord)
        {
            throw new System.NotImplementedException();
        }



        public Game(global::BedBihan.Board board)
        {
            // TODO: Complete member initialization
            this.board = board;
        }

        public void updatePoint()
        {
            foreach(Player p in list_players)
            {
                int score = 0;
                foreach(Unit u in p.faction.troops)
                {
                    Field f = this.board.grid[u.coordinates.x, u.coordinates.y].field;
                    score += u.getPoints(f);
                }
                p.points = score;
            }
        }

        public bool over()
        {
            bool bool1 = true;
            bool bool2 = true;
            foreach(Unit u in list_players[0].faction.troops)
            {
                bool1 &= ( u.currentHP <= 0);
            }
            foreach (Unit u in list_players[1].faction.troops)
            {
                bool2 &= ( u.currentHP <= 0);
            }
            return bool1 || bool2;
        }

        public Player getWinner()
        {
            this.updatePoint();
            if (list_players[0].points > list_players[1].points)
            {
                return list_players[0];
            }
            else
            {
                return list_players[1];
            }
        }

    }
}
