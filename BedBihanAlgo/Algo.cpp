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
*  Generate a int[][] that represent the map.
*/

int** Algo::mapGenerator(const int size){
	int i;
	int nb_hex = size*size;
	int nb_hex_by_world[4]; // fix nb_world
	for (i = 0; i < nb_world; i++){
		nb_hex_by_world[i] = nb_hex / 4;
	}
	
	int** map = (int **) malloc(size * sizeof(int *));
	for (i = 0; i < size; i++){
		map[i] = (int *)malloc(size * sizeof(int));
	}
	
	 int random;

	i = 0;
	while (i < (size * size) ) {
		random = rand() % nb_world;
		if (nb_hex_by_world[random] > 0){
			map[i/nb_world][i%nb_world] = random;
			nb_hex_by_world[random]--;
			i++;
		}
	}

	return map;
}


