#include <iostream>
#include <stdlib.h>
#include <locale.h>

using namespace std;

int main(int argc, const char * argv[]) {
    setlocale(LC_ALL, "portuguese");
    int x;
    x = 100;

    int *ptr;
    ptr = &x;

    cout << "O valor de X é: " << *ptr << endl;
    cout << endl;
    return 0;
}
