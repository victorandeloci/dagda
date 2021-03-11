import os
os.system('clear')

People = collections.namedtuple('Pessoa', 'id nome idade email')

people = []
people.append(People(1, 'Gandalf', 5000, 'gandalf_das_novinhas@gmail.com'))

for p in people:
    print(f'Id: {p.id}')
    print(f'Nome: {p.nome}')
    print(f'Idade: {p.idade}')
    print(f'E-mail: {p.email}')
