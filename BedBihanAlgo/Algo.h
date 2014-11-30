#pragma once
#include <stdlib.h> 
#include <time.h>
#include <algorithm>   

/**
	Algo class contains the c++ calculation fonctions (algorithme of battle and map building for example)
*/


class Algo
{

private:
	int const nb_world = 4;
public:
	Algo() {}
	~Algo() {}
	int computeFoo(int x);
	int** mapGenerator(const int size);
	int numberOfConfrontations(const int attackerHP, const int defenderHP);
	double chanceOfVictory(const int attackerAtt, const int defenderDef);
	double godDecision();
	int damagesInflicted(int attack, int currentHP, int maxHP);
};


