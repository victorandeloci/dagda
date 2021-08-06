#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int vet[3] = {1, 2, 3};

    int *ptrVet;
    ptrVet = vet;

    int resu;

    for (int i = 0; i <= 2; i++)
        resu = resu + ptrVet[i];

    cout << "A soma é dos indices do vetor é: " << resu;

    cout << endl;
    return 0;
}
