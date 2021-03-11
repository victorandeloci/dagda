import os

os.system('cls')
print("Aula 01 - Exercício 01")

base = float(input("Valor da Base do Triângulo: "))
altura = float(input("Valor da Altura do Triângulo: "))

area = (base*altura)/2

print("A Area do Triângulo é: ", area)

######################################################################################

print("Aula 01 - Exercício 02")

peso = float(input("Valor do Peso em KG: "))
altura = float(input("Valor da Altura em metros (Use . para casas decimais): "))

imc = (peso/(altura**altura))

print("O IMC é: %.2f" %imc)

######################################################################################

print("Aula 01 - Exercício 03")

preco = float(input("Preço do Produto em R$: "))

newPreco = preco + ((preco/100)*12)

print("O Novo preço é R$ %.2f" %newPreco)
print("O Antigo preço era R$ %.2f" %preco)
print("O aumento foi de R$ %.2f" %((preco/100)*12))

######################################################################################