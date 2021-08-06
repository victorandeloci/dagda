#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int Soma(int *ptrX, int *ptrY);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int x, y;

    x = 100;
    y = 200;

    cout << "A soma é: " << Soma(&x, &y);

    cout << endl;
    return 0;
}

int Soma(int *ptrX, int *ptrY){
    return *ptrX + *ptrY;
}
