using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class Unit
    {
       
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

        public Faction faction
        {
            get;
            set;
        }


        protected float[] costOfMovement;

        private int maxMovementPoints;

        public float movementPoints
        {
            get;
            set;
        }
        public Coordinates coordinates
        {
            get;
            set;
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


        public bool canMove(Field field)
        {
            return (movementPoints - this.costOfMovement[(int)field]) >= 0;
        }

        /**
         * \brief lower units movement points 
         */
        public void looseMovementPoints(Field field)
        {
            this.movementPoints -= this.costOfMovement[(int)field];
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
            this.maxHP = 10;
            this.currentHP = 5;
            this.attack = 2;
            this.defense = 1;
            this.maxMovementPoints = 1;
            this.movementPoints = 1;
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
        public void moveOn(Hexagon hexagon)
        {

        }



        /**
         * \fn 
         * \brief 
         * \param[in] 
         * \ return 0 if it kill the defender, 1 if he died during the battle, else return 2
         */
        public int fightAgainst(Unit defender)
        {
            int numberOfConfrontations = WrapperGate.access.numberOfConfrontations(this.currentHP, defender.currentHP);
            while (numberOfConfrontations > 0)
            {

                // konsole
                double chanceOfVictory = WrapperGate.access.chancesOfVictory(this.attack,defender.defense);
                double godDecision = WrapperGate.access.godDecision();

                if (chanceOfVictory > godDecision)
                // attacker wins
                {
                    
                    defender.looseHealthPoints(WrapperGate.access.damagesInflicted(this.attack,this.currentHP,this.maxHP));
                    if (defender.isDead())
                    {
                        numberOfConfrontations = 0;
                        defender.destroy();
                        return 0;
                    } 
                }
                else
                // attacker looses
                {
                    this.looseHealthPoints(WrapperGate.access.damagesInflicted(defender.attack,defender.currentHP,defender.maxHP));
                    if (this.isDead())
                    {
                        numberOfConfrontations = 0;
                        return 1;
                    }
                }
                numberOfConfrontations--;
            }
            return 2;
            
        }


        /**
         * \fn 
         * \brief 
         * \param[in] 
         */
        void destroy()
        {
            
        }

        




        /*
         * \brief return the number of points the unit got
         * */
        public abstract int getPoints();
    }
}
