#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

void Exibir(int *ptrVet);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int vet[3] = {1, 2, 3};

    Exibir(vet);

    cout << endl;
    return 0;
}

void Exibir(int *ptrVet){
    cout << "O primeiro indice é: " << ptrVet[0] << endl;
    cout << "O segundo indice é: " << ptrVet[1] << endl;
    cout << "O terceiro indice é: " << ptrVet[2] << endl;

}
