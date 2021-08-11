from pymprog import*

# Dados de entrada
C = [5.2, 6.8, 7.1, 2.5] # custos
R = [0.22, 0.07, 0.55, 0.08] # requisitos (min e max)
P = [[0.26, 0.01, 0.25, 0.1],
     [0.05, 0.05, 0.26, 0.02],
     [0.6, 0.75, 0.45, 0.24],
     [0.07, 0, 0.01, 0.08]] # percentuais

n = len(C) # numero de ingredientes
m = len(R) # número de nutrientes

begin('Barra')

# variaveis
x = var('x', n) # cria n variaveis (x0, x1, x2, x4)

# função objetivo
minimize(sum(C[i] * x[i] for i in range(n)))

# restrições
for j in range(2):
  sum(P[j][i] * x[i] for i in range(n)) >= R[j]

for j in range(2, 4):
  sum(P[j][i] * x[i] for i in range(n)) <= R[j]

sum(x[i] for i in range(n)) == 1

# resolver
solve()

print('Valor ótimo = {:.2f}'.format(vobj()))

for i in range(n):
  print('X[{}] = {}'.format(i, x[i].primal))
