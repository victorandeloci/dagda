#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

void troca(int *ptrX, int *ptrY);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int x = 100;
    int y = 200;

    troca(&x, &y);

    cout << "O valor de X Alterado pela função é: " << x << endl;
    cout << "O valor de Y Alterado pela função é: " << y << endl;

    cout << endl;
    return 0;
}

void troca(int *ptrX, int *ptrY){
    int temp = *ptrX;
    *ptrX = *ptrY;
    *ptrY = temp;
}
