import os

os.system('cls') 

print("Aula 03 - Exercício 01 - Tuplas")

par = []
impar = []
numbers = []
pos = []

def limpar_tela():
    os.system('cls')

def ler_valor():
    cont = 0
    while cont < 6:
        try:
            num = 0
            num = int(input("Informe um valor: "))
            numbers.append(num)
        except ValueError:
            print("Apenas letras")
        cont += 1
        continue

def par_impar(numbers):
    for i in numbers:
        resto = i % 2
        if resto == 0:
            par.append(i)
        else:
            impar.append(i)
    
def maior(numbers):
    return max(numbers)

def menor(numbers):
    return min(numbers)

def sum(numbers):
    soma = 0
    for j in numbers:
        soma = soma + j
    return soma

def positivo(numbers):
    for t in numbers:
        if t >= 0:
            pos.append(t)

def main():
    ler_valor()
    par_impar(numbers)
    positivo(numbers)
    limpar_tela()
    print(f"Quantidade de Pares: {len(par)}")
    print(f"Números impares: {impar}")
    print(f"A soma dos números é: {sum(numbers)}")
    print(f"O menor número é: {menor(numbers)}")
    print(f"O maior número é: {maior(numbers)}")
    print(f"A quantidade de positivo é: {len(pos)}")

main()

######################################################################################

import random
print("Aula 03 - Exercício 02 - Tuplas")

def range_array():
    array = []
    for j in range(10):
        array.append(random.randint(0, 255))
    return array

matriz = []
for i in range(10):
    matriz.append(range_array())
    print(matriz[i])

######################################################################################

print("Aula 03 - Exercício 03 - Tuplas")

situation = []

def limpar_tela():
    os.system('cls')

def ler_dados():
    dados = []
    cont = 0
    while cont < 6: 
        aluno = []
        aluno.append(input("Digite o nome: do Aluno: "))
        aluno.append(float(input("Digite a primeira nota: ")))
        aluno.append(float(input("Digite a segunda nota: ")))
        dados.append(aluno)
        cont += 1
    return dados

def media(numbers):
    soma = 0
    for j in numbers:
        soma = soma + j
    avg = soma / len(numbers)
    return avg

def situacao(media):
    if media >= 6:
        situation.append("Aprovado")
    elif media >= 4 and media < 6:
        situation.append("Exame")
    else:
        situation.append("Reprovado")

def main():
    alunos = ler_dados()
    medias = []
    for aluno in alunos:
        notas = []
        notas.append(aluno[1])
        notas.append(aluno[2])
        avg = media(notas)
        medias.append(avg)
        situacao(avg)

    aprovado = 0.0
    exame = 0.0
    reprovado = 0.0
    for i in range(len(alunos)):
        print(f"Aluno: {alunos[i][0]}\t 1° Prova: {alunos[i][1]}\t 2° Prova: {alunos[i][2]}\t Média: {medias[i]}\t Situação: {situation[i]}")
        if situation[i] == "Aprovado":
            aprovado += 1
        elif situation[i] == "Exame":
            exame += 1
        else:
            reprovado += 1
    
    print(f"Média da classe: {media(medias)}")
    print(f"Aprovados: {100/len(alunos)*aprovado}%")
    print(f"Exame: {100/len(alunos)*exame}%")
    print(f"Reprovados: {100/len(alunos)*reprovado}%")

main()

######################################################################################

print("Aula 03 - Exercício 04 - Tuplas")

def limpar_tela():
    os.system('cls')

def ler_dados():
    dados = []
    cont = 0
    while cont < 5: 
        produto = []
        produto.append(input("Digite o nome do Produto: "))
        produto.append(float(input("Digite o preço do produto: ")))
        dados.append(produto)
        cont += 1
    return dados

def main():
    produtos = ler_dados()
    for produto in produtos:
        precos = []
        precos.append(produtos[1])
    
    limpar_tela()
    
    inferior = 0
    entre = []
    superior = []
    media = 0.0
    for i in range(len(produtos)):
        print(f"Produto: {produtos[i][0]}\t Preço: {produtos[i][1]}")
        if produtos[i][1] < 50:
            inferior += 1
        elif produtos[i][1] >= 50 and produtos[i][1] <= 100:
            entre.append(produtos[i][0])
        else:
            superior.append(produtos[i][1])
        media += produtos[i][1]
        

    print(f"Quantidades de produtos inferior a R$50,00: {inferior}")
    print(f"Nomes de produtos entre R$50,00 e R$100,00: {entre}")
    print(f"Média dos preços superior a R$100,00: {media/len(superior)}")

main()

######################################################################################

print("Aula 03 - Exercício 01 - Lista")

def checkPalindrome (palindrome):
    palindrome_list=list(palindrome)
    palindrome_list_reverse=palindrome_list[::-1]
    if palindrome_list==palindrome_list_reverse:
        var=True
    else:
        var=False
    print(var)    

palindrome=input("Entre com o palindromo:")
checkPalindrome(palindrome)

######################################################################################

print("Aula 03 - Exercício 02 - Lista")

vet = []
vet_div=[]
for i in range(15):
    vet.append(int(input("Insira o valor ")))
maior=max(vet)
vet_div = [float(i) / maior for i in vet]
print(vet_div)

######################################################################################

print("Aula 03 - Exercício 03 - Lista")

def adjacentElementsProduct(inputArray):
    
    length = len(inputArray) 
    sum = []
    for i in range(length-1):
        sum.append(inputArray[i] * inputArray[i+1])
    print(max(sum))
vet = []
for i in range(int(input("Número de elementos do vetor "))):
    vet.append(int(input("Elemento do vetor ")))
adjacentElementsProduct(vet)


######################################################################################

print("Aula 03 - Exercício 01 e 02 - Conjunto e dicionário")

import operator
import random
import string
from unicodedata import normalize as norm

def lerNome():
    return input ("Escreva o nome: ")

def removerAcentos(txt):
    return norm('NFKD', txt).encode('ASCII', 'ignore').decode('ASCII')

def gerarUsername(data, nome):
    usr = nome[0].lower() + nome.split(' ').pop().lower()
    usr =removerAcentos(usr)

    i = 1
    usr_temp = usr
    while(data.get(usr) != None):
        usr = usr_temp + str(i).zfill(2)
        i = i + 1

    data[usr] = [nome, gerarPassword()]

def gerarPassword():
    pwd = [random.choice(string.ascii_letters + string.digits + "!@#$%&") for _ in range(10)]
    return "".join(pwd)

def exibirDados(data):
    cols = os.get_terminal_size().columns
    os.system('clear')
    print("="*cols)
    print ("%-40s %-20s %-20s" %("Nome: ", "UserName", "Password"))
    for item in data:
        print ("%-40s %-20s %-20s" %(item[1][0], item[0], item[1][1]))
    print("="*cols)

def main():
    data = {}
    os.system('clear')
    resp = ""

    while resp != "N":
        gerarUsername(data, lerNome())
        resp = input("Deseja continuar? ").upper()
    data = sorted(data.items(), key=operator.itemgetter(0))

    exibirDados(data)

main()