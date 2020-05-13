#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int x, y;

    x = 100;
    y = 400;

    int *ptrX, *ptrY;

    ptrX = &x;
    ptrY = &y;

    int resu = *ptrX + *ptrY;

    cout << "O valor é: " << resu;

    cout << endl;
    return 0;
}
