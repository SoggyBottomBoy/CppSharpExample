#pragma once
class Example
{
public:
	Example(int value);
	Example Add(Example other);
	int GetValue();
private:
	int value;
};

