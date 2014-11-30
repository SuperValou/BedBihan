#include "Algo.h"

/**
 *	Contains the c++ calculation fonctions (algorithme of battle and map building for example)
 */

/*
 *  Multiply x by two
 */
int Algo::computeFoo(int x) 
{ 
	return x * 2;
}



/*
*  Generate an int[][] that represents the map.
*/

int** Algo::mapGenerator(const int size)
{
	int i;
	int nb_hex = size*size;
	int nb_hex_by_world[4]; // fix nb_world
	for (i = 0; i < nb_world; i++)
	{
		nb_hex_by_world[i] = nb_hex / 4;
	}
	
	int** map = (int **) malloc(size * sizeof(int *));
	for (i = 0; i < size; i++)
	{
		map[i] = (int *)malloc(size * sizeof(int));
	}

	int random;

	i = 0;
	while (i < (size * size) ) 
	{
		random = rand() % nb_world;
		if (nb_hex_by_world[random] > 0)
		{
			map[i/nb_world][i%nb_world] = random;
			nb_hex_by_world[random]--;
			i++;
		}
	}

	return map;
}



/*
*	return the number of confrontations in a fight
*/
int Algo::numberOfConfrontations(const int attackerHP, const int defenderHP)
{
	int maxNumberOfConfrontations = 2 + std::max(attackerHP, defenderHP);
	srand(time(NULL));
	return (rand() % (maxNumberOfConfrontations - 2)) + 2;
}

/*
* return the chances of victory for the attacker (number between 0 and 1)
*/
double Algo::chanceOfVictory(int attackerAtt, int defenderDef)
{
	if (attackerAtt > defenderDef)
	{
		return 1 - 0.5*((double) defenderDef / (double) attackerAtt);
	}
	return 0.5*((double) attackerAtt / (double) defenderDef);
}

/*
*	return God's decision about who wins the confrontation (number between 0 and 1)
*/
double Algo::godDecision()
{
	//srand(time(NULL));
	return ((double)rand() / (RAND_MAX));
}

/*
*	return the amout of damages inflicted to a unit
*/
int Algo::damagesInflicted(int attack, int currentHP, int maxHP)
{
	return ((int) std::floor(attack * ((double) currentHP / (double) maxHP)));
}