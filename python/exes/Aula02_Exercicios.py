import os

os.system('cls')

print("Aula 02 - Exercício 01")

nome = input("Digite o nome do Produto: ")
valor = float(input("Digite o Valor do Produto em R$: "))

if valor < 0:
    print("Apenas valores positivos")
    newValor = valor
elif valor < 50:
    print("Descontos aplicados apenas para mais de R$ 50")
    newValor = valor
elif valor >= 50 and valor < 200:
    newValor = valor-((valor/100)*5)
elif valor >= 200 and valor < 500:
    newValor = valor-((valor/100)*6)
elif valor >= 500 and valor < 1000:
    newValor = valor-((valor/100)*7)
else:    
    newValor = valor-((valor/100)*8)

print("O nome do produto é: ", nome)
print("O valor original era R$ %.2f" %valor)
print("O Novo valor é R$ %.2f" %newValor)

######################################################################################

print("Aula 02 - Exercício 02")

resistencias = {400, 300, 200, 700}

total = 0

for r in resistencias:
    total += r

print("A resistência total é: ", total)
print("A menor resistência é: ", min(resistencias))
print("A maior resistência é: ", max(resistencias))

######################################################################################

print("Aula 02 - Exercício 03")

numero = int(input("Digite o numero para a tabuada: "))

for i in range(10):
    print("%d x %d = %d" % (numero, i+1, numero*(i+1)))

######################################################################################

print("Aula 02 - Exercício 04")

ano = str(input("Digite o ano para saber o século, com 4 algarimos, Exemplo '1992': "))

if ano[2:4] != '00':
    sec = int(ano[0:2])+1
    print("teste if")
else:
    sec = int(ano[0:2])
    print("teste else")

print("O século do ano digitado é:", sec)

######################################################################################

print("Aula 02 - Exercício 05")

print("IMC")
op = input("Deseja continuar? {s/n}: ")
while op == 's':
    try:
        peso = int(input("Qual é o seu peso em KG, exemplo '85': "))
        altura = float(input("Qual a sua altura em Metros, exemplo '1.77': "))
        imc = peso/(altura**altura)
        print("O teu IMC é: %.2f " %imc)
        if imc > 28:
            print("IMC acima")
        elif imc < 18:
            print("IMC abaixo")
        else:
            print("IMC bom")
        op = input("Deseja continuar? {s/n}: ")
    except ValueError:
        print("Deixa de ser burro, não coloque letras!")
        op = input("Deseja continuar? {s/n}: ")
    continue

######################################################################################

print("Aula 02 - Exercício 01 - função")

par = []
impar = []
numbers = []

def limpar_tela():
    os.system('cls')

def ler_valor():
    op = input("Deseja continuar? {s/n}: ")
    while op == 's':
        try:
            num = 0
            num = int(input("Informe um valor: "))
            numbers.append(num)
            op = input("Deseja continuar? {s/n}: ")
        except ValueError:
            print("Apenas números")
            op = input("Deseja continuar? {s/n}: ")
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

def media(numbers):
    soma = 0
    for j in numbers:
        soma = soma + j
    avg = soma / len(numbers)
    return avg

def main():
    ler_valor()
    par_impar(numbers)
    limpar_tela()
    print(f"Quantidade de Pares: {len(par)}")
    print(f"Números impares: {impar}")
    print(f"O menor número é: {menor(numbers)}")
    print(f"O maior número é: {maior(numbers)}")
    print(f"A média dos números é: {media(numbers)}")

main()

######################################################################################

print("Aula 02 - Exercício 02 - função")

def limpar_tela():
    os.system('cls')

def ler_dados():
    dados = []
    dados.append(input("Digite seu nome: "))
    dados.append(input("Digite seu endereco: "))
    dados.append(input("Digite seu telefone: "))
    dados.append(input("Digite seu e-mail: "))
    dados.append(input("Digite sua escolaridade: "))
    dados.append(input("Digite sua experiencia: "))
    return dados

def construir_html(dados):
    hmtl = f"""
        <!DOCTYPE html>
        <html>
        <head>
            <title>Currículo</title>
        </head>
        <body>
            <h1>Nome: {dados[0]}</h1>
            <h2>Endereço: {dados[1]}</h2>
            <h2>Telefone: {dados[2]}</h2>
            <h2>E-mail: {dados[3]}</h2>
            <h2>Escolaridade: {dados[4]}</h2>
            <h2>Experiência Profissional: {dados[5]}</h2>
        </body>
        </html>
    """
    return hmtl

def main():
    limpar_tela()
    print(construir_html(ler_dados()))

main()