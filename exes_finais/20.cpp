#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

void Operacoes(
    int *ptrVet,
    int *ptrSoma,
    int *ptrSub,
    int *ptrMult,
    int *ptrDiv);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int vet[8], soma, sub, div, mult;

    for (int i = 0; i <= 7; i++) {
        cout << "Insira o " << (i + 1) << "(o) valor: " << endl;
        cin >> vet[i];
    }

    Operacoes(vet, &soma, &sub, &mult, &div);

    cout << "A soma de 1 e 8 é: " << soma << endl;
    cout << "A subtração de 2 e 7 é: " << sub << endl;
    cout << "A multiplicação de 3 e 6 é: " << mult << endl;
    if (vet[4] == 0)
        cout << "Divisão por zero impossível!" << endl;
    else
        cout << "A divisão de 4 e 5 é: " << div << endl;

    cout << endl;
    return 0;
}

void Operacoes(
   int *ptrVet,
   int *ptrSoma,
   int *ptrSub,
   int *ptrMult,
   int *ptrDiv){

    *ptrSoma = ptrVet[0] + ptrVet[7];
    *ptrSub = ptrVet[1] - ptrVet[6];
    *ptrMult = ptrVet[2] * ptrVet[5];
    if (ptrVet[4] != 0)
        *ptrDiv = ptrVet[3] / ptrVet[4];
}
