using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public static class Game
    {
        public IBoard board
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int nbTourMax
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int nbTour
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


        public Player redPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Player bluePlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void nextTurn()
        {
            /*
             * Compter les points
             *
             */
        }

        public void playGame()
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
            
        
        // changer
        public static Unit[] getUnitsOn(Coordinates coord)
        {
            /*
            Unit[] list;
            for each (List.Joueurs lj)
            {
                for each (List lj.troop )
                {
                    if (troop.coordinate == coord)
                        list.add(troops[i]);
                }
            }
              */
            return null;
        }



    }
}
