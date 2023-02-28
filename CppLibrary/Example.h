#include "Globals.h"

#pragma once
class DLL_API Example
{
public:
	Example(int value);
	Example Add(Example other);
	int GetValue();
private:
	int value;
};

