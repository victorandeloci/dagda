import os
os.system('clear')

for i in range(5):
    print(i)

for i in range(1, 10, 2):
    print(i)

for i in range(10, 1, -1):
    print(i)

sum = 0
for i in range(5):
    sum += i
else:
    print(f'Soma: {sum}')
