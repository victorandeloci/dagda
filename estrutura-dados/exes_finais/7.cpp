#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int vet[3];

    int *ptrVet;

    ptrVet = vet;

    for (int i = 0; i <= 2; i++) {
        cout << "Insira o " << (i + 1) << "(o) valor: " << endl;
        cin >> ptrVet[i];
    }

    for (int i = 0; i <= 2; i++) {
        cout << "O valor do vetor (" << i << ") é: " << ptrVet[i] << endl;
    }

    cout << endl;
    return 0;
}
