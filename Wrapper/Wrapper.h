#pragma once 
#include "Algo.h"

using namespace System;
namespace Wrapper 
{
	public ref class WrapperAlgo 
	{
	private:
		Algo* algo;

	public:
		WrapperAlgo(){ algo = new Algo(); }
		~WrapperAlgo(){ delete algo; }
		int computeFoo(int x) { return algo->computeFoo(x); }
	};
}