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

        public void restorePoint()
        {
            foreach(Unit u in faction.troops)
            {
                u.restoreMovementPoints();
            }
        }
        public bool belongTo(Unit u)
        {
            return this.faction.troops.Contains<Unit>(u);
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

        public void remove(Unit delU)
        {
            int tabsize = this.faction.troops.Length;
            Unit[] newTroop = new Unit[tabsize];
            int i = 0;
            foreach(Unit u in this.faction.troops)
            {
                if (u != delU)
                {
                    newTroop[i] = u;
                    i++;
                }
            }
        }



    }
}
