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
	};
}