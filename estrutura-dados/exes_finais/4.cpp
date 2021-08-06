#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int x, y;

    x = 10;
    y = 20;

    int *ptrX, *ptrY;

    ptrX = &x;
    ptrY = &y;

    int temp;
    temp = *ptrX;

    cout << "Valor do ptrX ANTES: " << *ptrX << endl;
    cout << "Valor do ptrY ANTES: " << *ptrY << endl;

    *ptrX = *ptrY;
    *ptrY = temp;

    cout << "Valor do ptrX DEPOIS: " << *ptrX << endl;
    cout << "Valor do ptrY DEPOIS: " << *ptrY << endl;

    cout << endl;
    return 0;
}
