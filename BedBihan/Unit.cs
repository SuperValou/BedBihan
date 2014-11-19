using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Unit
    {
        

        public int lifePoints
        {
            get;
            private set;
        }

        public int lifeMax
        {
            get;
            private set;
        }

        public int attack
        {
            get;
            private set;
        }


        public int defense
        {
            get;
            private set;
        }

        public int movementPoints
        {
            get;
            private set;
        }

        public People people
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Coordinates coordinates
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


        private int[] costsOfMovement;


        public Unit()
        {
            for (int i = 0; i < costsOfMovement.Length; i++)
            {
                costsOfMovement[i] = 1;
            }
        }


        /**
         * \fn 
         * \brief 
         * \param[in] 
         */
        public abstract void moveOn(Hexagon hexagon);



        /**
         * \fn 
         * \brief 
         * \param[in] 
         */
        void fightAgainst(Unit defender)
        {
            Random random = new Random();
            double fightNumber = 3 + random.NextDouble() * (2+ Math.Max(this.lifePoints, defender.lifePoints)); // calcul à vérifier mais là on s'en branle
            while (fightNumber > 0)
            {
                double chanceOfVictory = 0.5*(this.attack / defender.defense);
                double godDecision = random.NextDouble();
                if (chanceOfVictory > godDecision)
                // attacker wins
                {
                    defender.lifePoints -= this.attack * (this.lifePoints / this.lifeMax);
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


        /**
         * \fn 
         * \brief 
         * \param[in] 
         */
        void destroy()
        {

        }

        /**
         * \fn 
         * \brief 
         * \param[in] 
         */
        public int getCostOfMovementOn(Field field)
        {
            return costsOfMovement[(int) field];
        }


    }
}
