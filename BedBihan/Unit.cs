using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Unit
    {
        public People people
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
        public int lifePoints
        {
            get;
            private set;
        }
        protected float[] costOfMovement;
        private int maxMovementPoints;
        public int movementPoints
        {
            get;
            private set;
        }
        public Coordinates coordinates
        {
            get;
            private set;
        }


        /**
         * \brief lower units life points 
         * \param[in] the damages the unit takes
         */
        public void looseLifePoints(int damages)
        {
            this.lifePoints -= damages;
        }

        /**
         * \brief lower units movement points 
         * \param[in] the cost of movement the unit has to pay
         */
        public void looseMovementPoints(int costOfMovement)
        {
            this.movementPoints -= costOfMovement;
        }

        /**
         * \brief restore units movement points 
         */
        public void restoreMovementPoints()
        {
            this.movementPoints = this.maxMovementPoints;
        }


        /**
         * \brief standart Unit constructor
         */
        public Unit()
        {
            this.lifeMax = 1;
            this.attack = 1;
            this.defense = 1;
            this.maxMovementPoints = 1;
            costOfMovement = new float[Enum.GetNames(typeof(Field)).Length];
            for (int i =0; i<costOfMovement.Length;i++)
            {
                this.costOfMovement[i] = 1;
            }
        }

        /**
         * \brief Unit constructor
         */
        public Unit(int maxLife, int att, int def, int maxMov, Coordinates spawningPoint)
        {
            this.lifeMax = maxLife;
            this.attack = att;
            this.defense = def;
            this.maxMovementPoints = maxMov;
            this.coordinates = spawningPoint;
            costOfMovement = new float[Enum.GetNames(typeof(Field)).Length];
            for (int i = 0; i < costOfMovement.Length; i++)
            {
                this.costOfMovement[i] = 1;
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
         * \brief get the cost of movement on a specific field
         * \param[in] the type of field
         * \param[out] cost of movement on the type of field
         */
        public float getCostOfMovementOn(Field field)
        {
            return costOfMovement[(int) field];
        }


    }
}
