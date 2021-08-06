import os
os.system('clear')

while True:
    try:
        n = int(input('Entre com um número: '))
    except ValueError as e:
        print(f'O valor informado não é um número: {e}')
