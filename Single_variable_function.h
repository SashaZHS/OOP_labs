#pragma once

#include<iostream>
#include<cmath>

using namespace std;

class Single_variable_function {
protected:
	double data;
public:
	virtual void calculate() = 0;
};


class Sin : public Single_variable_function
{
public:
	void calculate() override;

	Sin(double x) {
		data = x;
	}
};

class Cos : public Single_variable_function
{
public:
	void calculate() override;

	Cos(double x) {
		data = x;
	}
};
};
};