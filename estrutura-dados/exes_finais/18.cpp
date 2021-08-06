#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int Soma(int *ptrVet);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int vet[3] = {1, 2, 3};

    cout << "A soma é: " << Soma(vet) << endl;
    cout << endl;
    return 0;
}

int Soma(int *ptrVet){
    int soma = 0;
    for (int i = 0; i <= 2; i++) {
        soma = soma + ptrVet[i];
    }

    return soma;
}
