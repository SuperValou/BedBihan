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
        public int maxHP
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
        public int currentHP
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
        public void looseHealthPoints(int damages)
        {
            this.currentHP -= damages;
        }

        /**
         * \brief lower units life points 
         * \param[in] the damages the unit takes
         */
        public bool isDead()
        {
            return this.currentHP <= 0;
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
            this.maxHP = 1;
            this.currentHP = 1;
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
            this.maxHP = maxLife;
            this.currentHP = maxLife;
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
        public void fightAgainst(Unit defender)
        {
            int numberOfConfrontations = WrapperGate.access.numberOfConfrontations(this.currentHP, defender.currentHP);
            while (numberOfConfrontations > 0)
            {

                // konsole
                double chanceOfVictory = WrapperGate.access.chancesOfVictory(this.attack,defender.defense);
                double godDecision = WrapperGate.access.godDecision();

                Console.WriteLine("tour "+numberOfConfrontations + " : " + this.currentHP + " " + defender.currentHP);
                Console.WriteLine("Chance of victory : "+chanceOfVictory);
                Console.WriteLine("godDecision : "+godDecision);

                if (chanceOfVictory > godDecision)
                // attacker wins
                {
                    
                    defender.looseHealthPoints(WrapperGate.access.damagesInflicted(this.attack,this.currentHP,this.maxHP));
                    if (defender.isDead())
                    {
                        numberOfConfrontations = 0;
                        defender.destroy();
                        return;
                    } 
                }
                else
                // attacker looses
                {
                    this.looseHealthPoints(WrapperGate.access.damagesInflicted(defender.attack,defender.currentHP,defender.maxHP));
                    if (this.isDead())
                    {
                        numberOfConfrontations = 0;
                        this.destroy(); // ??
                    }
                }
                
                numberOfConfrontations--;
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
