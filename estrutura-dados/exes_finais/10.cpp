#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int vet[8];

    int *ptrVet;

    ptrVet = vet;

    for (int i = 0; i <= 7; i++) {
        cout << "Insira o " << (i + 1) << "(o) valor: " << endl;
        cin >> ptrVet[i];
    }

    cout << "A soma de 1 e 8 é: " << (ptrVet[0] + ptrVet[7]) << endl;
    cout << "A subtração de 2 e 7 é: " << (ptrVet[1] - ptrVet[6]) << endl;
    cout << "A multiplicação de 3 e 6 é: " << (ptrVet[2] * ptrVet[5]) << endl;
    if (ptrVet[4] == 0)
        cout << "Divisão por zero impossível!" << endl;
    else
        cout << "A divisão de 4 e 5 é: " << (ptrVet[3] / ptrVet[4]) << endl;

    cout << endl;
    return 0;
}
