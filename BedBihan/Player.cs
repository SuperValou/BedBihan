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
            switch (people)
            {
                case "korrigan":
                    this.faction = new KorriganFaction(size);
                    break;
                case "human":
                    this.faction = new HumanFaction(size);
                    break;
                case "elf":
                    this.faction = new ElfFaction(size);
                    break;
            } // add error for default ?
        }


        public string name
        {
            get;
            set;
        }


        public int points
        {
            get;
            set;
        }

        public AbstractFaction faction
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
