#include"Single_variable_function.h"

void Sin::calculate() {
	cout << "Значение синуса :" << endl;
	cout << sin(data) << endl;
	cout << "Его производной :" << endl;
	cout << cos(data) << endl;
};

void Cos::calculate() {
	cout << "Значение косинуса :" << endl;
	cout << cos(data) << endl;
	cout << "Его производной :" << endl;
	cout << "Его производной :" << endl;
	cout << "Его производной :" << endl;
	cout << (-1)*sin(data) << endl;
};