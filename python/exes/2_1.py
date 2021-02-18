# Victor Andeloci - RA: 2840481823035

import os
os.system('clear')

product = input('Entre com o produto: ')
value = float(input('Entre com o valor: '))

discount = 0
if value >= 50 and value < 200:
    discount = 5
elif value >= 200 and value < 500:
    discount = 6
elif value >= 500 and value < 1000:
    discount = 7
elif value >= 1000:
    discount = 8

newValue = value - (value * discount / 100)

print(f'Produto: {product} - Valor Original: {value} - Valor com Desconto: {newValue}')
