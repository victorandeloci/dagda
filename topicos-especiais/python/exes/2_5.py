# Victor Andeloci - RA: 2840481823035

import os
os.system('clear')

keepInputting = True
while keepInputting:
    try:
        weight = float(input('Insira o peso: '))
        height = float(input('Insira a altura: '))

        imc = weight / (height * height)

        print(f'IMC: {imc}')
    except ValueError as e:
        print(f'O valor informado não é um número: {e}')

    code = input('Deseja continuar? [S / N]: ')
    if code.upper() == 'N':
        keepInputting = False
    else:
        os.system('clear')
