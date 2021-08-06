#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

void Soma(int *ptrVet1, int *ptrVet2, int *ptrVet3);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int vet1[3] = {1, 2, 3};
    int vet2[3] = {4, 5, 6};
    int vet3[3];

    Soma(vet1, vet2, vet3);

    for (int i = 0; i <= 2; i++)
        cout << vet1[i] << " + " << vet2[i] << " = " << vet3[i] << endl;

    cout << endl;
    return 0;
}

void Soma(int *ptrVet1, int *ptrVet2, int *ptrVet3){

    for (int i = 0; i <= 2; i++)
        ptrVet3[i] = ptrVet1[i] + ptrVet2[i];
}
