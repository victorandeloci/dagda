#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int a, b;
    cout << "Digite o primeiro número: " << endl;
    cin >> a;
    cout << "Digite o segundo número: " << endl;
    cin >> b;

    int *ptrA, *ptrB;
    ptrA = &a;
    ptrB = &b;

    int resu;

    resu = *ptrA + *ptrB;

    cout << "Resultado: " << resu << endl << endl;
    cout << "ptrA: " << *ptrA << endl;
    cout << "ptrB: " << *ptrB << endl;

    cout << endl;
    return 0;
}
