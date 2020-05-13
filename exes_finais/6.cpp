#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int vet[3] = {1, 2, 3};

    int *ptrVet;

    ptrVet = vet;

    for (int i = 0; i <= 2; i++) {
        cout << "O valor do vetor (" << i << ") é: " << ptrVet[i] << endl;
    }

    cout << endl;
    return 0;
}
