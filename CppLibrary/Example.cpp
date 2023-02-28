#include "Example.h"

Example::Example(int value){
	this->value = value;
}

Example Example::Add(Example other) {
	auto value = this->value + other.value;
	return Example(value);
}

int Example::GetValue() {
	return this->value;
}