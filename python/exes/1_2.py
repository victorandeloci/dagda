# Victor Andeloci - RA: 2840481823035

import os
os.system('clear')

weight = float(input('Insira o peso: '))
height = float(input('Insira a altura: '))

imc = weight / (height * height)

print(f'IMC: {imc}')
