using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Unit
    {
        // -- properties --

        public int color
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        } // blue or red (plutôt un enum plutot qu'un int en fait non ?)

        public int lifePoints
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int lifeMax
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int attack
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int defense
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int movementPoints
        {
            get
            {
                return this.movementPoints;
            }
            set
            {
            }
        }


        // -- methods --

        // move the current unit and engage fight
        void moveOn (Hexagon hexagon)
        {
            this.movementPoints -= this.costOfMovementOn(hexagon.field);
            if (!hexagon.isFree() && hexagon.color() != this.color)
            {
                this.fightAgainst(hexagon.selectBestUnit());
                if (hexagon.isFree())
                {
                    hexagon.addUnit(this);
                    // this.previousHexagon.removeUnit(this); ?
                }
            }
        }
  
  
        // return cost of movement
        public int costOfMovementOn(int field)
        {
            return 1;
        }


        // manage fights
        void fightAgainst(Unit defender)
        {
            Random random = new Random();
            double fightNumber = 3 + random.NextDouble() * (2+ Math.Max(this.lifePoints, defender.lifePoints)); // à vérifier mais là on s'en branle
            while (fightNumber > 0)
            {
                double chanceOfVictory = 0.5*(this.color / defender.defense);
                double godDecision = random.NextDouble();
                if (chanceOfVictory > godDecision)
                // attacker wins
                {
                    defender.lifePoints -= this.lifePoints * (this.lifePoints / this.lifeMax);
                    if (defender.lifePoints < 0)
                    {
                        fightNumber = 0;
                        defender.destroy();
                        return;
                    } 
                }
                else
                // attacker looses
                {
                    this.lifePoints -= defender.defense * (defender.lifePoints / defender.lifeMax);
                    if (this.lifePoints < 0)
                    {
                        fightNumber = 0;
                        this.destroy(); // ??
                    }
                }
            }
        }

        // destroy the current unit
        void destroy()
        {

        }


    }
}
