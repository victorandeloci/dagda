# Victor Andeloci - RA: 2840481823035

import os
os.system('clear')

year = int(input('Insira o ano: '))

value = (year / 100)

if float(round(value)) < value:
    sec = round(value) + 1
else:
    sec = round(value)

print(f'Século {sec}')
