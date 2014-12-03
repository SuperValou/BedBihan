using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class Player
    {

        public Player(int size, string people)
        {
       //     this.faction = new Faction(size, people);   TO FIX !!
        }

        public int points
        {
            get;
            set;
        }

        public Faction faction
        {
            get;
            set;
        }

        public String pseudo
        {
            get;
            set;
        }

        public void playTurn()
        {
            /*
             * for each unit
             * move
             */
        }



    }
}
