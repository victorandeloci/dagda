import os
import operator
import random
import string
from unicodedata import normalize as norm

def read():
    return norm('NFKD', input('Informe o nome: ')).encode('ASCII', 'ignore').decode('ASCII')

def generateUsername(data, name):
    user = name[0].lower() + name.split(' ').pop().lower()

    i = 1
    temp_user = user
    while(data.get(user) != None):
        user = temp_user + str(i).zfill(2)
        i += 1

    data[user] = [name, generatePassword()]

def generatePassword():
    password = [random.choice(string.ascii_letters + string.digits + '!@#$%') for _ in range(10)]
    return ''.join(password)

def showData(data):
    cols = os.get_terminal_size().columns
    os.system('clear')

    print('=' * cols)
    print('%-40s %-20s %-20s'%('Nome', 'Username', 'Senha'))
    print('=' * cols)

    for item in data:
        print('%-40s %-20s %-20s'%(item[1][0], item[0], item[1][1]))

def main():
    os.system('clear')

    data = {}
    resp = ''

    while resp != 'N':
        generateUsername(data, read())
        resp = input('Deseja continuar? [S] ou [N]: ').upper()

    data = sorted(data.items(), key = operator.itemgetter(0))
    showData(data)

main()
