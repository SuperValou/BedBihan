#pragma once
#include <stdlib.h> 

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
};


