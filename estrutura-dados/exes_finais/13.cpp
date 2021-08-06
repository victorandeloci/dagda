#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

void Operacoes(
int *ptrX,
int *ptrY,
int *ptrSoma,
int *ptrSub,
int *ptrMult,
int *ptrDiv);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int x = 100;
    int y = 200;
    int soma, sub, mult, div;

    Operacoes(&x, &y, &soma, &sub, &mult, &div);

    cout << "A soma de X e Y executado pela função é: " << soma << endl;
    cout << "A subtração de X e Y executado  pela função é: " << sub << endl;
    cout << "A multiplicacão de X e Y executado função é: " << mult << endl;
    cout << "A divisão de X e Y executado pela função é: " << div << endl;

    cout << endl;
    return 0;
}

void Operacoes(
   int *ptrX,
   int *ptrY,
   int *ptrSoma,
   int *ptrSub,
   int *ptrMult,
   int *ptrDiv){
    *ptrSoma = *ptrX + *ptrY;
    *ptrSub = *ptrX - *ptrY;
    *ptrMult = *ptrX * *ptrY;
    *ptrDiv = *ptrX / *ptrY;
}
