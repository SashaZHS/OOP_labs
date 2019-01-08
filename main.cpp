// ВИКОНАВ СТУДЕНТ ІП-72 ЖУРБЕЛЮК ОЛЕКСАНДР

#include"QuadraticEquation.h"
int main() {
    setlocale(LC_ALL, "Russian");
    setlocale(LC_NUMERIC,"C");
    int a,b,c;
    cout<<"Квадратное уравнение имеет вид:"<<endl;
    cout<< "ax^2 + bx + c"<<endl;
    cout<<"Введите целочисленное a:"<<endl;
    cin>>a;
    cout<<"Введите целочисленное b:"<<endl;
    cin>>b;
    cout<<"Введите целочисленное c:"<<endl;
    cin>>c;
    try {
    QuadraticEquation eq(a,b,c);
    eq.findSolution();
    eq.print();
    } catch (Error &e) {
        e.print_err();
    }
    system("pause");
}
