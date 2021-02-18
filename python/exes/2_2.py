# Victor Andeloci - RA: 2840481823035

import os
os.system('clear')

resists = []

i = 0
while len(resists) < 4:
    resists.insert(i, float(input('Insira uma resistência: ')))
    i = i + 1

re = 0
bR = resists[0]
lR = resists[0]
for r in resists:
    re = re + r
    if bR < r:
        bR = r
    elif lR > r:
        lR = r

print(f'Equivalente: {re}\n Menor: {lR}\n Maior: {bR}')
