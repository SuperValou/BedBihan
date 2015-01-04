#pragma once 
#include "Algo.h"

/**
	the WrapperAlgo class is used to access the c++ functions of the Algo class
*/

using namespace System;
namespace Wrapper 
{
	public ref class WrapperAlgo
	{
	private:
		Algo* algo;	// attribute to access the Algo functions

	public:
		WrapperAlgo()
		{
			algo = new Algo();
		}

		~WrapperAlgo()
		{
			delete algo;
		}


		/**
		 *	wrapped functions
		 */

		int computeFoo(int x)
		{
			return algo->computeFoo(x);
		}

		int** mapGenerator(int size)
		{
			return algo->mapGenerator(size);
		}

		int numberOfConfrontations(int attackerHP, int defenderHP)
		{
			return algo->numberOfConfrontations(attackerHP, defenderHP);
		}

		double chancesOfVictory(int attackerAtt, int defenderDef)
		{
			return algo->chanceOfVictory(attackerAtt, defenderDef);
		}

		double godDecision()
		{
			return algo->godDecision();
		}

		int damagesInflicted(int attack, int currentHP, int maxHP)
		{
			return algo->damagesInflicted(attack, currentHP, maxHP);
		}
	};
}