#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

void troca(int *ptrX);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");
    int x;
    x = 100;

    troca(&x);

    cout << "O valor de X Alterado pela função é: " << x << endl;

    cout << endl;
    return 0;
}

void troca(int *ptrX){
    *ptrX = 200;
}
