﻿// lab3.cpp : Defines the entry point for the console application.
//
// ВИКОНАВ СТУДЕНТ іП-72 ЖУРБЕЛЮК ОЛЕКСАНДР

#include "stdafx.h"
#include"Single_variable_function.h"

int main() {
	setlocale(LC_ALL, "Russian");
	setlocale(LC_NUMERIC, "C");
	setlocale(LC_NUMERIC, "C");

	double val;
	cout << "Введите значение" << endl;
	cin >> val;

	Single_variable_function *second = new Sin(val);
	second->calculate();
	Single_variable_function *third = new  Cos(val);
	third->calculate();

	return 0;
}
