#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

void Preencher(int *ptrVet);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int vet[4];
    Preencher(vet);

    for (int i = 3; i >= 0; i--) {
        cout << "Valor da posição " << (i + 1) << ": " << vet[i] << endl;
    }

    cout << endl;
    return 0;
}

void Preencher(int *ptrVet){
    for (int i = 0; i <= 3; i++) {
        cout << "Insira o " << (i + 1) << "o valor: " << endl;
        cin >> ptrVet[i];
    }
}
