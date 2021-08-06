#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

void Atribui(int *ptr);

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");

    int ptr;
    Atribui(&ptr);

    cout << "O valor de ptr é: " << ptr << endl;

    cout << endl;
    return 0;
}

void Atribui(int *ptr){
    int x = 500;
    *ptr = x;
}
